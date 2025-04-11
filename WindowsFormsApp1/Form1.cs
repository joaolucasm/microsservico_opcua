using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Opc.UaFx.Client;
using WindowsFormsApp1;

namespace microsservico_opcua
{
    public partial class Form1 : Form
    {
        List<List<Pacote2001_0_auxiliarTD>> pacotesDeConexao = new List<List<Pacote2001_0_auxiliarTD>>(); // Uma lista com até 10 IEDS cadastradas, será utilizada para compartilhar com a thread em execução
        List<Pacote1001_1> resultadosBuscas = new List<Pacote1001_1>(); // Lista para guardar o resultado das buscas no servidores das ieds

        private static Mutex nossoMutex = new Mutex(); //usados para bloquear regioes de memoria compartilhadas entre threads
        private readonly object locker = new object();
        private List<Thread> th = new List<Thread>();
        private int contadorListaThread = 0;
        private int contadorListaPacote = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            instanciadorTextBox();
        }

        private void instanciadorTextBox()
        {
            txtBoxCorrente.Text = "ns=??;i=??";
            txtBoxTensao.Text = "ns=??;i=??";
            txtBoxAngTensao.Text = "ns=??;i=??";
            txtBoxFreq.Text = "ns=??;i=??";
            txtBoxPotRealVAr.Text = "ns=??;i=??";
            txtBoxPotApar.Text = "ns=??;i=??";
            txtBoxPotRealWw.Text = "ns=??;i=??";
            txtBoxFatorPot.Text = "ns=??;i=??";
        }

        private void salvarBotton_Click(object sender, EventArgs e)
        {

            MapOPC mapOpc = new MapOPC(txtBoxConexao.Text,txtBoxCorrente.Text,txtBoxTensao.Text,txtBoxAngTensao.Text,txtBoxPotApar.Text,txtBoxPotRealVAr.Text,txtBoxPotRealWw.Text,txtBoxFatorPot.Text,txtBoxFreq.Text);
            Pacote2001_0_auxiliarTD novaInstancia;


            if (cbPausado.Text == "Não")
                novaInstancia = new Pacote2001_0_auxiliarTD((int)numericUpDownCodId.Value, (int)numericUpDownTaxLeitura.Value, txtBoxDns.Text, cbTipoIED.Text, txtBoxIp.Text, txtBoxCircuito.Text, txtBoxLocal.Text, txtBoxMac.Text, cbTipoAtivo.Text, 0, mapOpc);
            else
                novaInstancia = new Pacote2001_0_auxiliarTD((int)numericUpDownCodId.Value, (int)numericUpDownTaxLeitura.Value, txtBoxDns.Text, cbTipoIED.Text, txtBoxIp.Text, txtBoxCircuito.Text, txtBoxLocal.Text, txtBoxMac.Text, cbTipoAtivo.Text, 1, mapOpc);

            pacotesDeConexao[contadorListaPacote].Add(novaInstancia);

            if (pacotesDeConexao[contadorListaPacote].Count == 1)
            {
                th.Add(new Thread(new ThreadStart(() => conexaoServidorOpc(contadorListaPacote))));
                th[contadorListaThread].Name = "Thread " + contadorListaThread.ToString();
                th[contadorListaThread].Start();
                contadorListaThread++;
            }
            else
            {
                if(pacotesDeConexao[contadorListaPacote].Count == 9)
                {
                    lock (locker)
                    {
                        pacotesDeConexao[contadorListaPacote].Add(novaInstancia);
                        pacotesDeConexao.Add(new List<Pacote2001_0_auxiliarTD>());
                    }
                    contadorListaPacote++;
                }
                else
                {
                    lock (locker)
                    {
                        pacotesDeConexao[contadorListaPacote].Add(novaInstancia);
                    }
                }
            }
        }

        //--------------------------------------------------- INICIO DOS MÉTODOS OPERADORES-------------------------------------------------------------
        private void conexaoServidorOpc(int valorIndexDaLista)
        {
            //laço infinito para verificação constate
            while (true)
            {
                List<Pacote2001_0_auxiliarTD> conexaoIed;

                lock (locker)
                {
                    conexaoIed = new List<Pacote2001_0_auxiliarTD>(pacotesDeConexao[valorIndexDaLista]);
                }

                if (conexaoIed.Count != 0) 
                {
                    //laço de varredura das ieds
                    for (int i = 0; i < conexaoIed.Count; i++)
                    {
                        if (conexaoIed[i].tempoDecorrido == 0)
                        {

                            Pacote1001_1 dadosServidor = new Pacote1001_1();
                            conexaoIed[i].tempoDecorrido = conexaoIed[i].taxaLeitura;

                            try
                            {
                                var client = new OpcClient(conexaoIed[i].mapOpc.linkConexao);
                                client.Connect();

                                dadosServidor.corrente = Convert.ToDouble(client.ReadNode(conexaoIed[i].mapOpc.corrente));
                                dadosServidor.tensao = Convert.ToDouble(client.ReadNode(conexaoIed[i].mapOpc.tensao));
                                dadosServidor.angTensao = Convert.ToDouble(client.ReadNode(conexaoIed[i].mapOpc.angTensao));
                                dadosServidor.potAparenteVA = Convert.ToDouble(client.ReadNode(conexaoIed[i].mapOpc.potAparenteVA));
                                dadosServidor.potReatVAr = Convert.ToDouble(client.ReadNode(conexaoIed[i].mapOpc.potReatVAr));
                                dadosServidor.potRealW = Convert.ToDouble(client.ReadNode(conexaoIed[i].mapOpc.potRealW));
                                dadosServidor.fatorP = Convert.ToDouble(client.ReadNode(conexaoIed[i].mapOpc.fatorP));
                                dadosServidor.freq = Convert.ToDouble(client.ReadNode(conexaoIed[i].mapOpc.freq));

                                nossoMutex.WaitOne();
                                resultadosBuscas.Add(dadosServidor);
                                nossoMutex.ReleaseMutex();

                                client.Disconnect();

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex.Message);
                            }
                        }
                        conexaoIed[i].tempoDecorrido--;
                    }
                }
                else
                {
                    //colocar a logica para desligar a thread caso nao tenha nenhuma ied nessa lista dela
                }

                Thread.Sleep(1000);// após todas as verificações, colocar a thread para dormir 1 segundo exato
            }

        }
    }
}

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
        List<Pacote2001_0> pacotesTotais = new List<Pacote2001_0>(); // Uma lista com todas as IEDS cadastradas
        List<Pacote2001_0> pacotesParciais = new List<Pacote2001_0>(); // Uma lista com até 10 IEDS cadastradas, será utilizada para compartilhar com a thread em execução
        List<Pacote1001_1> resultadosBuscas = new List<Pacote1001_1>(); // Lista para guardar o resultado das buscas no servidores das ieds

        private static Mutex nossoMutex = new Mutex(); //usados para bloquear regioes de memoria compartilhadas entre threads
        private readonly object locker = new object();
        private List<Thread> th = new List<Thread>();

        public int contadorLista = 0;

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

            contadorLista++;

            MapOPC mapOpc = new MapOPC(txtBoxConexao.Text,txtBoxCorrente.Text,txtBoxTensao.Text,txtBoxAngTensao.Text,txtBoxPotApar.Text,txtBoxPotRealVAr.Text,txtBoxPotRealWw.Text,txtBoxFatorPot.Text,txtBoxFreq.Text);
            int pausado;

            if(cbPausado.Text == "Não")
                pausado = 0;
            else
                pausado = 1;

            Pacote2001_0 novaInstancia = new Pacote2001_0((int)numericUpDownCodId.Value, (int)numericUpDownTaxLeitura.Value, txtBoxDns.Text, cbTipoIED.Text, txtBoxIp.Text, txtBoxCircuito.Text, txtBoxLocal.Text, txtBoxMac.Text, cbTipoAtivo.Text, pausado, mapOpc);
          
            pacotesTotais.Add(novaInstancia);   

            if (pacotesParciais.Count == 0)
            {
                pacotesParciais.Add(novaInstancia);
                th.Add(new Thread(new ThreadStart(conexaoServidorOpc)));
            }
            else
            {
                if(pacotesParciais.Count != 10)
                {
                    
                }
                else
                {
                      
                }
            }
        }

        //--------------------------------------------------- INICIO DOS MÉTODOS OPERADORES-------------------------------------------------------------
        private void conexaoServidorOpc()
        {

            List<int> tempoLeituraIed = new List<int>();
            List<int> tempoDecorrido = new List<int>();
            int segundos = 0;
            int count;

            //Instanciando os valores de taxa de leitura em uma lista e iniciando uma lista de comparação 
            //for (int i = 0; i < 1; i++) 
            //{
            //    tempoLeituraIed.Add(conexaoIed[i].taxaLeitura);
            //    tempoDecorrido.Add(0);
            //}

            //laço infinito que irá ficar rodando realizando a leitura
            while (true)
            {
                List<Pacote2001_0> conexaoIed;

                count = pacotesParciais.Count;
        

                lock (locker)
                {
                    conexaoIed = new List<Pacote2001_0>(pacotesParciais);
                }

                for (int i = 0; i < conexaoIed.Count; i++) 
                {
                    if (tempoLeituraIed[i] == tempoDecorrido[i])
                    {
                        Pacote1001_1 dadosServidor = new Pacote1001_1();

                        try
                        {
                            tempoDecorrido [i] = 0;
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
                }
                Thread.Sleep(1000);// após todas as verificações, colocar a thread para dormir 1 segundo exato
                tempoDecorrido[segundos]++;
            }
        }


    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using WindowsFormsApp1;

namespace microsservico_opcua
{
    public class Pacote2001_0
    {
        public static string uri = "2001/0";
        public static string seqName = "codIdIed";

        public int codID;
        public int taxaLeitura; //segundos a cada leitura
        public string DNSlot;
        public string tipoIed;
        public string ip;
        public string escopo = String.Empty;
        public string circuito;
        public string local;
        public string mac;
        public string tipoAtivoAssociado;
        public string protocolo = "OPC UA";
        public int pausado; //0 para não iniciar pausado, 1 para iniciar pausado
        public MapOPC mapOpc;
                
       
        public Pacote2001_0(Pacote2001_0 pacote)
        {
            this.codID = pacote.codID;
            this.taxaLeitura = pacote.taxaLeitura;
            this.DNSlot = pacote.DNSlot;
            this.tipoIed = pacote.tipoIed;
            this.ip = pacote.ip;
            this.circuito = pacote.circuito;
            this.local = pacote.local;
            this.mac = pacote.mac;
            this.tipoAtivoAssociado = pacote.tipoAtivoAssociado;
            this.pausado = pacote.pausado;
            this.mapOpc = pacote.mapOpc;
        }

        public Pacote2001_0(int codID,
            int taxaLeitura,
            string DNSlot,
            string tipoIed,
            string ip,
            string circuito,
            string local,
            string mac,
            string tipoAtivoAssociado,
            int pausado,
            MapOPC mapOPC     
            )
        {
            this.codID = codID;
            this.taxaLeitura = taxaLeitura;
            this.DNSlot = DNSlot;
            this.tipoIed = tipoIed;
            this.ip = ip;
            this.circuito = circuito;
            this.local = local;
            this. mac = mac;
            this.tipoAtivoAssociado = tipoAtivoAssociado;
            this.pausado = pausado;
            this.mapOpc = mapOPC;
        }
    }
}

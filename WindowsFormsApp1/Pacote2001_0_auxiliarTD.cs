using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using microsservico_opcua;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    internal class Pacote2001_0_auxiliarTD : Pacote2001_0
    {
        public int tempoDecorrido;

        public Pacote2001_0_auxiliarTD(int codID, int taxaLeitura, string DNSlot, string tipoIed, string ip, string circuito, string local, string mac, string tipoAtivoAssociado, int pausado, MapOPC mapOPC)
            : base(codID, taxaLeitura, DNSlot, tipoIed, ip, circuito, local, mac, tipoAtivoAssociado, pausado, mapOPC)
        {
            tempoDecorrido = taxaLeitura;
        }

        public Pacote2001_0_auxiliarTD(Pacote2001_0 pacote)
            : base(pacote) 
        {
            this.tempoDecorrido = pacote.taxaLeitura;
        }
    }

}

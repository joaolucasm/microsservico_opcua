using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Pacote1001_1
    {
        public double corrente;
        public double tensao;
        public double angTensao;
        public double potAparenteVA;
        public double potReatVAr;
        public double potRealW;
        public double fatorP;
        public double freq;

        public Pacote1001_1()
        {

        }

        public Pacote1001_1(double corrente, double tensao, double angTensao, double potAparenteVA, double potReatVAr, double potRealW, double fatoP, double freq)
         {
            this.corrente = corrente;
            this.tensao = tensao;
            this.angTensao = angTensao;
            this.potAparenteVA = potAparenteVA;
            this.potReatVAr = potReatVAr;
            this.potRealW = potRealW;
            this.fatorP = fatoP;
            this.freq = freq;
         }
    }
}

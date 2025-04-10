using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace microsservico_opcua
{
    public class MapOPC
    {
        public string linkConexao;
        public string corrente;
        public string tensao;
        public string angTensao;
        public string potAparenteVA;
        public string potReatVAr;
        public string potRealW;
        public string fatorP;
        public string freq;
        public List<FlagsAnalog> analogInputs;
        public List<FlagsBinary> binaryInputs, binaryOutputs;

        public MapOPC(string linkConexao, string corrente, string tensao, string angTensao, string potAparenteVA, string potReatVAr, string potRealW, string fatoP, string freq, List<FlagsAnalog> analogInputs, List<FlagsBinary> binaryInputs, List<FlagsBinary> binaryOutputs)
        {
            this.linkConexao = linkConexao;
            this.corrente = corrente;
            this.tensao = tensao;
            this.angTensao = angTensao;
            this.potAparenteVA = potAparenteVA;
            this.potReatVAr = potReatVAr;
            this.potRealW = potRealW;
            this.fatorP = fatoP;
            this.freq = freq;
            this.analogInputs = analogInputs;
            this.binaryInputs = binaryInputs;
            this.binaryOutputs = binaryOutputs;
        }
        public MapOPC(string linkConexao, string corrente, string tensao, string angTensao, string potAparenteVA, string potReatVAr, string potRealW, string fatoP, string freq)
        {
            this.linkConexao = linkConexao;
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

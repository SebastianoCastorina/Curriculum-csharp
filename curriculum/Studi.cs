using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curriculum
{
    internal class Studi
    {
        public Studi() { }  
        public Studi(string Competenza, string nomeIstituto, string Inizio, string Fine)
        { this.Qualifica = Competenza; this.Istituto = nomeIstituto; this.Dal = Inizio; this.Al = Fine;}
        public string Qualifica {  get; set; }
        public string Istituto { get; set;}
        public string Dal {  get; set; }
        public string Al {  get; set; }

    }
}

using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curriculum
{
    internal class Esperienza
    {
        public Esperienza() { }
        public Esperienza(string PostoDiLavoro, string titoloLavorativo, string Inizio, string Fine, string Description, string Mansioni) 
        { this.Azienda = PostoDiLavoro; this.jobTitle = titoloLavorativo; this.Dal = Inizio; this.Al = Fine; this.Descrizione = Description; this.Compiti = Mansioni; }
       
        public string Azienda { get; set; }
        public string jobTitle { get; set; }
        public string Dal {  get; set; }
        public string Al {  get; set; }
        public string Descrizione { get; set; }
        public string Compiti { get; set; }
        
    }
}

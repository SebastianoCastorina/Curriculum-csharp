using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curriculum
{
    internal class InformazioniPersonali
    {
        public InformazioniPersonali() { }
        public InformazioniPersonali(string Name, string Surname, int Phone, string emailAddress)
        { this.Nome = Name; this.Cognome = Surname; this.Telefono = Phone; this.Email = emailAddress; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }

    }
}

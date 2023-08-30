using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace curriculum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Curriculum curriculum = new Curriculum();
            

            
            curriculum.infoPersonali = new InformazioniPersonali("Matteo","Renzi",322045894,"erounboyscout@allafacciadiputin.com");
            Studi studiEffettuati1 =new Studi("Pescatore","Maremma Maiala", "dal 1980","al 2023");
            Studi studiEffettuati2 = new Studi("Cacciatore di opportunità", "Azienda del Padre", "ancora in corso", "--");
            curriculum.studiEffettuati.Add(studiEffettuati1);
            curriculum.studiEffettuati.Add(studiEffettuati2);
            Esperienza Esperienza1 = new Esperienza("Boyscout", "Buffone", "Da sempre", "Per sempre", "First reaction SCIOC", "Insegnante di Inglese all'estero");
            curriculum.impieghiPrecedenti.ListaEsperienze.Add(Esperienza1);
            Console.WriteLine(curriculum.infoPersonali.Nome);
            Console.WriteLine(curriculum.infoPersonali.Cognome);
            Console.WriteLine(curriculum.infoPersonali.Telefono);
            Console.WriteLine(curriculum.infoPersonali.Email);
          
            foreach (var item in curriculum.studiEffettuati)
            {
                Console.WriteLine(item.Qualifica+ " " + item.Istituto + " " + item.Dal+" "+ item.Al);
                
            }
            foreach (var item in curriculum.impieghiPrecedenti.ListaEsperienze)
            {
            Console.WriteLine(item.Azienda + " " + item.Compiti + " " + item.jobTitle + " " + item.Dal + " " + item.Al);
            }
            
            Console.ReadLine();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace lösenorduppgift
{
    public class information
    {
        public class lösenordinfo
        {
            private string lösenord = "";
            // printar lösenordet
            public string visalösenord()
            {
                return this.lösenord;
            }
            // sätter in ett valfritt lösenord som man valt
            public void setlösenord(string lösenord)
            {
                this.lösenord = lösenord;
            }
        }
        
        
    }
}
namespace uppgift3
{
    public class Bank
    {
        // ger varje variabel en get och set funktion direkt utan en funktion
        public string Ägare { get; set; }
        public float Balance { get; }
        public string Kortnummer { get; }
        // en funktion som gör att man kan sätta in sina egna värden senare när man skapar nya variabler i en klass
        public Bank(string namn, float Totalpengar, string nummer)
        {
            this.Ägare = namn;
            this.Balance = Totalpengar;
            this.Kortnummer = "kortnummer " + nummer;
            
        }
    }
}

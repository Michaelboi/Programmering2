using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lösenorduppgift
{
    public class information
    {
        public class lösenordinfo
        {
            private string lösenord = "";
            public string visalösenord()
            {
                return this.lösenord;
            }
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
        public string Ägare;
        public float Balance;
        public string Kortnummer;

        public Bank(string namn, float Totalpengar, string nummer)
        {
            this.Ägare = namn;
            this.Balance = Totalpengar;
            this.Kortnummer = nummer;
        }
    }
}
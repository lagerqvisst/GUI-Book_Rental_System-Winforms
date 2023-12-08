using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Resenär : Person
    {
        public Resenär(string förnamn, string efternamn, string mailadress)
        {
            this.förnamn = förnamn;
            this.efternamn = efternamn;
            this.mailadress = mailadress;

        }
    }
}

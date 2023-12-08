using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Bokmaskin
    {
        public static int idCounter = 0; 

        public int maskinID;
        public List<Bok> böcker;
        public int antalBöcker;

        public Bokmaskin() 
        {
            böcker = new List<Bok>();
            antalBöcker = böcker.Count;
            maskinID = nyttMaskinID();

            
        }  

        public int nyttMaskinID()
        {
            return idCounter++;
        }
    }
}
    
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

        public string maskinBeskrivning { get; set; }
        public int maskinID { get; set; }
        public List<Bok> böcker { get; set; }

        public List<BokLån> lånadeBöckerFrånMaskin { get; set; }

        
        public Bokmaskin(string maskinBeskrivning) 
        {
            böcker = new List<Bok>();
            lånadeBöckerFrånMaskin = new List<BokLån>();    
            maskinID = nyttMaskinID();
            this.maskinBeskrivning = maskinBeskrivning;
            
        }  

        public int nyttMaskinID()
        {
            return idCounter++;
        }
    }
}
    
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Tågstation
    {
        public string stad { get; set; }
        public List<Bokmaskin> Bokmaskiner { get; set; }
        public Tågstation(string stad)
        { 
            this.stad = stad;   
            Bokmaskiner = new List<Bokmaskin>();
        } 
    }
}

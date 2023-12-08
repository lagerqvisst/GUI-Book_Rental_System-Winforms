using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Bok
    {
        public int isbn { get; set; }
        public string titel { get; set; }
        public string författare { get; set; }
        public int sidor { get; set; }
        public string genre { get; set; }


        public Bok(int isbn, string titel, string författare, int sidor, string genre)
        {
            this.isbn = isbn;
            this.titel = titel;
            this.författare = författare;
            this.sidor = sidor; 
            this.genre = genre;
        }
    }
}

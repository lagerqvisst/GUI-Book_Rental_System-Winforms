using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace Models
    {
        public class BokLån
        {
            public string lånadBok { get; set; }
            public DateTime utlåningsDatum { get; set; }
            public DateTime återlämningsDatum { get; set; }
            public int dagarKvarLån { get; set; }
            public string resenärNamn { get; set; }

            public Bok bok;

            public Resenär resenär;

            public Bokmaskin maskinLånadFrån; 

            public BokLån(Bok bok, Resenär resenär, Bokmaskin maskin)
            {
                this.bok = bok;
                lånadBok = bok.titel;

                this.resenär = resenär;
                resenärNamn = $"{resenär.förnamn} {resenär.efternamn}";

                this.maskinLånadFrån = maskin;

                utlåningsDatum = DateTime.Now;
                återlämningsDatum = utlåningsDatum.AddMonths(1);
                dagarKvarLån = (återlämningsDatum - utlåningsDatum).Days;
        }
        }
    }

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

            public Bok bok;

            public BokLån(Bok bok)
            {
                this.bok = bok;
                lånadBok = bok.titel;
                utlåningsDatum = DateTime.Now;
                återlämningsDatum = utlåningsDatum.AddMonths(1);
                dagarKvarLån = (återlämningsDatum - utlåningsDatum).Days;
        }
        }
    }

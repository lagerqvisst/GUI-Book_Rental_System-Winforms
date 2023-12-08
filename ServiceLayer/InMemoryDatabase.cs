using Models;

namespace ServiceLayer
{
    public class InMemoryDatabase
    {
        public List<Bok> böcker = new List<Bok>();
        public List<Bokmaskin> bokmaskiner = new List<Bokmaskin>();
        public List<Maskinansvarig> maskinansvariga = new List<Maskinansvarig>();
        public List<Resenär> resenärer = new List<Resenär>(); 
        public List<Tågstation> tågstationer = new List<Tågstation>();

        public void Seed() 
        {
            //Skapa böcker
            Bok bok1 = new Bok(978912743, "Män som hatar kvinnor", "Stieg Larsson", 590, "Deckare"); böcker.Add(bok1);
            Bok bok2 = new Bok(978030747, "The Girl on the Train", "Paula Hawkins", 336, "Thriller"); böcker.Add(bok2);
            Bok bok3 = new Bok(978014311, "To Kill a Mockingbird", "Harper Lee", 281, "Roman"); böcker.Add(bok3);
            Bok bok4 = new Bok(978074327, "The Great Gatsby", "F. Scott Fitzgerald", 180, "Klassiker"); böcker.Add(bok4);
            Bok bok5 = new Bok(978074753, "Harry Potter and the Philosopher's Stone", "J.K. Rowling", 223, "Fantasy"); böcker.Add(bok5);
            Bok bok6 = new Bok(978006112, "The Catcher in the Rye", "J.D. Salinger", 277, "Roman"); böcker.Add(bok6);
            Bok bok7 = new Bok(978037453, "The Road", "Cormac McCarthy", 287, "Dystopi"); böcker.Add(bok7);
            Bok bok8 = new Bok(978140006, "The Kite Runner", "Khaled Hosseini", 371, "Drama"); böcker.Add(bok8);
            Bok bok9 = new Bok(978014241, "The Hunger Games", "Suzanne Collins", 374, "Science Fiction"); böcker.Add(bok9);
            Bok bok10 = new Bok(978073933, "The Da Vinci Code", "Dan Brown", 454, "Thriller"); böcker.Add(bok10);

            //Skapa bokmaskiner
            Bokmaskin maskin1 = new Bokmaskin(); bokmaskiner.Add(maskin1);
            Bokmaskin maskin2 = new Bokmaskin(); bokmaskiner.Add(maskin2); 
            Bokmaskin maskin3 = new Bokmaskin(); bokmaskiner.Add(maskin3);
            Bokmaskin maskin4 = new Bokmaskin(); bokmaskiner.Add(maskin4);
            Bokmaskin maskin5 = new Bokmaskin(); bokmaskiner.Add(maskin5);
            Bokmaskin maskin6 = new Bokmaskin(); bokmaskiner.Add(maskin6);

            //Fyll bokmaskinerna med böcker (alla maskiner får samma böcker)
            foreach(Bokmaskin maskiner in bokmaskiner)
            {
                foreach(Bok böcker in böcker) 
                {
                    maskiner.böcker.Add(böcker);
                }
            }

            Tågstation tågstation1 = new Tågstation("Göteborg C"); tågstationer.Add(tågstation1);
            Tågstation tågstation2 = new Tågstation("Stockholm C"); tågstationer.Add(tågstation2);
            Tågstation tågstation3 = new Tågstation("Malmö C"); tågstationer.Add(tågstation3);

            //GOT 2X, STHML 3X, Malmö 1x
            tågstation1.Bokmaskiner.Add(maskin1);
            tågstation1.Bokmaskiner.Add(maskin2);
            tågstation2.Bokmaskiner.Add(maskin3);
            tågstation2.Bokmaskiner.Add(maskin4);
            tågstation2.Bokmaskiner.Add(maskin5);
            tågstation3.Bokmaskiner.Add(maskin6);

            resenärer.Add(new Resenär("Elsa", "Andersson", "elsa.andersson@example.com"));
            resenärer.Add(new Resenär("Oscar", "Lindgren", "oscar.lindgren@example.com"));
            resenärer.Add(new Resenär("Emma", "Svensson", "emma.svensson@example.com"));
            resenärer.Add(new Resenär("Axel", "Johansson", "axel.johansson@example.com"));
            resenärer.Add(new Resenär("Linnéa", "Berg", "linnea.berg@example.com"));
            resenärer.Add(new Resenär("Viktor", "Eriksson", "victor.eriksson@example.com"));
            resenärer.Add(new Resenär("Isabelle", "Nilsson", "isabelle.nilsson@example.com"));
            resenärer.Add(new Resenär("Elias", "Gustafsson", "elias.gustafsson@example.com"));
            resenärer.Add(new Resenär("Amanda", "Larsson", "amanda.larsson@example.com"));
            resenärer.Add(new Resenär("Oliver", "Persson", "oliver.persson@example.com"));

            // Skapa och lägg till 5 maskinansvariga
            Maskinansvarig maskinansvarig1 = new Maskinansvarig("Bob", "Pettersson", "david.pettersson@example.com"); maskinansvariga.Add(maskinansvarig1);
            Maskinansvarig maskinansvarig2 = new Maskinansvarig("Roger", "Björk", "frida.bjork@example.com"); maskinansvariga.Add(maskinansvarig2);    
            Maskinansvarig maskinansvarig3 = new Maskinansvarig("Tjorven", "Eklund", "gustav.eklund@example.com"); maskinansvariga.Add(maskinansvarig3);
            Maskinansvarig maskinansvarig4 = new Maskinansvarig("Roffe", "Holm", "anna.holm@example.com"); maskinansvariga.Add(maskinansvarig4);
            Maskinansvarig maskinansvarig5 = new Maskinansvarig("Maestro", "Sjöberg", "oscar.sjoberg@example.com");maskinansvariga.Add(maskinansvarig5);

            //Fördelar ut bokmaskiner som specifika maskinansvariga är ansvariga för. 
            maskinansvarig1.maskiner.Add(maskin1);
            maskinansvarig2.maskiner.Add(maskin2);
            maskinansvarig3.maskiner.Add(maskin3);
            maskinansvarig4.maskiner.Add(maskin4);
            maskinansvarig5.maskiner.Add(maskin5);

        }

    }
}

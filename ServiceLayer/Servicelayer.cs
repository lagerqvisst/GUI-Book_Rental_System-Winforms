using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class Servicelayer
    {
        public InMemoryDatabase database = new InMemoryDatabase();

        public int VisaBokSaldo(Bokmaskin bokmaskin) 
        {
            int antalBöcker = bokmaskin.böcker.Count;
            return antalBöcker;
        }
        public Tågstation GetTågstation (string stad)
        {
            return database.tågstationer.FirstOrDefault(t => t.stad == stad); 
        }
        public Bokmaskin GetBokmaskin(int id)
        {
            return database.bokmaskiner.FirstOrDefault(i => i.maskinID == id); 
        }
        public void Seed()
        {
            database.Seed();    
        }
    }
}

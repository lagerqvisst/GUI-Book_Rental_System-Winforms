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
 
        public List<Resenär> GetResenärer()
        {
            return database.resenärer; 
        }
        public List<Maskinansvarig> GetMaskinansvariga() 
        {
            return database.maskinansvariga;
        }
        public List<Bokmaskin> GetMaskinerSomAnsvarigHar(Maskinansvarig maskinansvarig) 
        {
            return maskinansvarig.maskiner;
        }
        public List<BokLån> GetBokLån(Resenär resenär)
        {
            return resenär.lånadeBöcker;

        }
        public List<Tågstation> GetTågstationer()
        {
            return database.tågstationer;
        }
        public List<Bokmaskin> GetBokmaskiner(Tågstation tågstation)
        {
            return tågstation.Bokmaskiner;
        }
        public List<Bok> GetBöckerFrånMaskin(Bokmaskin bokmaskin) 
        {
            return bokmaskin.böcker;
        }
        public List<Bok> GetBöckerFrånDatabas() 
        {
            return database.böcker;
        }
        public List<BokLån> GetLånadeBöckerFrånMaskin(Bokmaskin bokmaskin) 
        {
            return bokmaskin.lånadeBöckerFrånMaskin;
        }
        public void LånaBok(Bok bok, Resenär resenär, Bokmaskin bokmaskin)
        {
            BokLån boklån = new BokLån(bok, resenär, bokmaskin);
            resenär.lånadeBöcker.Add(boklån);
            bokmaskin.lånadeBöckerFrånMaskin.Add(boklån);
            bokmaskin.böcker.Remove(bok); 
        }
        public void LämnaTillbakaBok(Bok bok, Resenär resenär, Bokmaskin nuvarandeMaskin, BokLån boklån)
        {
            nuvarandeMaskin.böcker.Add(bok);
            nuvarandeMaskin.lånadeBöckerFrånMaskin.Remove(boklån);
            resenär.lånadeBöcker.Remove(boklån);

            //Löser problemet som uppstår när en resenär lämnar tillbaka en bok på annan bokmaskin än den hen ursprungligen lånade från. 
            if (nuvarandeMaskin != boklån.maskinLånadFrån)
            {
                boklån.maskinLånadFrån.lånadeBöckerFrånMaskin.Remove(boklån);
            }

        }
        public void LäggTillBokIMaskinFrånLager(Bok bok, Bokmaskin bokmaskin) 
        {
            bokmaskin.böcker.Add(bok); 
        }

        public void Seed()
        {
            database.Seed();    
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FLYNET.Personeel
{
    public class NietVliegendPersoneelslid : Personeelslid
    {
        int UrenPerWeek;
        //enum- afdeling: Personeelsdienst, Boekhouding, Incheckbalie, Logistiek
        public enum Afdeling
        {
            Personeelsdienst, Boekhouding, Incheckbalie, Logistiek
        }

        public override decimal BasisKostprijsPerDag
        { get; set; }

        // constructor

        public NietVliegendPersoneelslid(string naam, string personeelsId, Afdeling value, int uren)
        {
            Naam = naam;
            PersoneelsId = personeelsId;
            UrenPerWeek = uren;
        }

        //Method
        public override decimal BerekenTotaleKostprijsPerDag()
        {
            decimal kostprijs;
            kostprijs = UrenPerWeek * 10;
            return kostprijs;
        }
    } 
}


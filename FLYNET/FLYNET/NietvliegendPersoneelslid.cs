using System;
using System.Collections.Generic;
using System.Text;

namespace FLYNET.Personeel
{
    abstract class NietVliegendPersoneelslid : Personeelslid
    {

        //enum- afdeling: Personeelsdienst, Boekhouding, Incheckbalie, Logistiek
        public enum Afdeling
        {
            Personeelsdienst, Boekhouding, Incheckbalie, Logistiek
        }

        public override decimal BasisKostprijsPerDag
        { get; set; }

        public override decimal TotaleKostprijsPerDag
        {
            get { return BasisKostprijsPerDag; }
        }
        // constructor

        public NietVliegendPersoneelslid(string naam, string personeelsId, Afdeling value)
        {
            Naam = naam;
            PersoneelsId = personeelsId;
        }
    } 
}


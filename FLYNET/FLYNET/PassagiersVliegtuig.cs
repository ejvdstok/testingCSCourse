using System;
using System.Collections.Generic;
using System.Text;

namespace FLYNET.Vloot
{
    abstract class PassagiersVliegtuig : Luchtvaartuig
    {
        private decimal BasisKostprijsPassagiersVliegtuig;
        public int AantalPassagiers;
        // met 10 euro verhogen per dag per zitplaats
        public override decimal BasisKostprijsPerDag
        { 
            get { return BasisKostprijsPassagiersVliegtuig;}
            set { BasisKostprijsPassagiersVliegtuig = 10 * AantalPassagiers; }
        }

        //constructor
        public PassagiersVliegtuig(string naamvliegtuig, int kruissnelheid, int vliegbereik, int zitplaatsen, decimal basiskostprijs)
        {
            NaamVliegtuig = naamvliegtuig;
            Kruissnelheid = kruissnelheid;
            VliegBereik = vliegbereik;
            AantalPassagiers = zitplaatsen;
            BasisKostprijsPerDag = basiskostprijs;
        }
    }
}

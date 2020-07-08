using System;
using System.Collections.Generic;
using System.Text;

namespace FLYNET.Vloot
{
     class PassagiersVliegtuig : Luchtvaartuig
    {
        private decimal BasisKostprijsPassagiersVliegtuig;
        public int AantalPassagiers;
        // met 10 euro verhogen per dag per zitplaats
        public override decimal BasisKostprijsPerDag
        {
            get { return BasisKostprijsPassagiersVliegtuig; }
            set { BasisKostprijsPassagiersVliegtuig = BasisKostprijsPerDag + 10 * AantalPassagiers; }
        }

        public override decimal TotaleKostprijsPerDag
        { get; }

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

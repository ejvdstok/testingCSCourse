using System;
using System.Collections.Generic;
using System.Text;

namespace FLYNET.Vloot
{
    class VrachtVliegtuig : Luchtvaartuig
    {
        private decimal BasisKostprijsVrachtVliegtuig;
        public int Laadvermogen;
        //kost verhoogd met 100euro voor vrachtvliegtuig.
        public override decimal BasisKostprijsPerDag
        {
            get { return BasisKostprijsVrachtVliegtuig; }
            set { BasisKostprijsVrachtVliegtuig = BasisKostprijsPerDag + 100 * Laadvermogen; }
        }

        public override decimal TotaleKostprijsPerDag
        { get; }

        //constructor
        public VrachtVliegtuig(string naamvliegtuig, int kruissnelheid, int vliegbereik, int laadvermogen, decimal basiskostprijs)
        {
            NaamVliegtuig = naamvliegtuig;
            Kruissnelheid = kruissnelheid;
            VliegBereik = vliegbereik;
            Laadvermogen = laadvermogen;
            BasisKostprijsPerDag = basiskostprijs;
        }
    }
}

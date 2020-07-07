using System;
using System.Collections.Generic;
using System.Text;

namespace FLYNET.Vloot
{
    abstract class VrachtVliegtuig : Luchtvaartuig
    {
        private decimal BasisKostprijsVrachtVliegtuig;
        public int Laadvermogen;
        //kost verhoogd met 100euro voor vrachtvliegtuig.
        public override decimal BasisKostprijsPerDag
        {
            get { return BasisKostprijsVrachtVliegtuig; }
            set { BasisKostprijsVrachtVliegtuig = 100 * Laadvermogen; }
        }

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

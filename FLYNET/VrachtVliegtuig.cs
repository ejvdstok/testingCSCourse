using System;
using System.Collections.Generic;
using System.Text;

namespace FLYNET.Vloot
{
    public class VrachtVliegtuig : Luchtvaartuig
    {
        private decimal BasisKostprijsVrachtVliegtuig;
        public int Laadvermogen;
        //kost verhoogd met 100euro voor vrachtvliegtuig.
        public override decimal BasisKostprijsPerDag
        {
            get { return BasisKostprijsVrachtVliegtuig; }
            set { BasisKostprijsVrachtVliegtuig = BasisKostprijsPerDag + 100 * Laadvermogen; }
        }

        //constructor
        public VrachtVliegtuig(string naamvliegtuig, int kruissnelheid, int vliegbereik, int laadvermogen, decimal basiskostprijs)
        {
            TypeVliegtuig = naamvliegtuig;
            Kruissnelheid = kruissnelheid;
            VliegBereik = vliegbereik;
            Laadvermogen = laadvermogen;
            BasisKostprijsPerDag = basiskostprijs;
        }

        //method
        public override decimal BerekenTotaleKostprijsPerDag()
        {
            decimal kostprijs;
            kostprijs = BasisKostprijsPerDag + 100m * Laadvermogen;
            return kostprijs;
        }

    }
}

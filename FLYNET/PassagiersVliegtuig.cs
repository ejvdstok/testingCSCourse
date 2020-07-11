using System;
using System.Collections.Generic;
using System.Text;

namespace FLYNET.Vloot
{
     public class PassagiersVliegtuig : Luchtvaartuig
    {
        private decimal BasisKostprijsPassagiersVliegtuig;
        public int AantalPassagiers { get; set; }
        // met 10 euro verhogen per dag per zitplaats
        public override decimal BasisKostprijsPerDag
        {
            get { return BasisKostprijsPassagiersVliegtuig; }
            set { BasisKostprijsPassagiersVliegtuig = BasisKostprijsPerDag + 10 * AantalPassagiers; }
        }

        //constructor
        public PassagiersVliegtuig(string naamvliegtuig, int kruissnelheid, int vliegbereik, int zitplaatsen, decimal basiskostprijs)
        {
            TypeVliegtuig = naamvliegtuig;
            Kruissnelheid = kruissnelheid;
            VliegBereik = vliegbereik;
            AantalPassagiers = zitplaatsen;
            BasisKostprijsPerDag = basiskostprijs;
        }
        //Method
        public override decimal BerekenTotaleKostprijsPerDag()
        {
            decimal kostprijs;
            kostprijs = BasisKostprijsPerDag + 10 * AantalPassagiers;
            return kostprijs;
        }
       
    }
}

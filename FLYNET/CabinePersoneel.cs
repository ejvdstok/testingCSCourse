using System;
using System.Collections.Generic;
using System.Text;

namespace FLYNET.Personeel
{
    class CabinePersoneel : VliegendPersoneel
    {
        private Graad graad;
        //werkpositie string 3 opties
        public readonly string Werkpositie;

        //grrad: purser of steward met exeption bij foute ingave
        public Graad Type
        {
            get { return graad; }
            set
            {
                if (!Enum.IsDefined(typeof(VliegendPersoneel.Graad), value))
                {
                    Console.WriteLine("Deze graad bestaad niet");
                }
                else if (value != VliegendPersoneel.Graad.Pulser || value != VliegendPersoneel.Graad.Steward)
                {
                    Console.WriteLine("Personen met deze graad werken niet in de cabine.");
                }
                graad = value;
            }
        }

        public override decimal BasisKostprijsPerDag
        {
            get { return BasisKostprijsPerDag; }
            set { BasisKostprijsPerDag = value; }
        }

        public override decimal TotaleKostprijsPerDag
        {
            get
            {
                decimal Salaris;
                if (Type == Graad.Pulser)
                {
                    Salaris = BasisKostprijsPerDag * 1.2M;
                }
                else //(Type == Graad.Steward)
                {
                    Salaris = BasisKostprijsPerDag;
                }
                if (HasCertificate("EHBO"))
                { Salaris = Salaris + 5m; }
                return Salaris;
            }

        }

        // 5€ extra voor ehbo certificaat

        //constructor
        public CabinePersoneel(string personeelsId, string naam, Graad value, decimal basiskostprijs, List<Certificate> cerificaten)
        {
            PersoneelsId = personeelsId;
            Naam = naam;
            BasisKostprijsPerDag = basiskostprijs;
            Certificates = cerificaten;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FLYNET.Personeel
{
    public class CabinePersoneel : VliegendPersoneel
    {
        public Graad graad;
        //werkpositie string 3 opties
        public readonly string Werkpositie;

        //grrad: purser of steward met exeption bij foute ingave
        public override Graad Graad
        {
            get { return graad; }
            set
            {
                if (!Enum.IsDefined(typeof(Graad), value))
                {
                    throw new Exception("Deze graad bestaad niet");
                }
                else if (value != Graad.Purser || value != Graad.Steward)
                {
                    throw new Exception($"Personen met deze graad werken niet in de cabine ({value.ToString()})");
                }
                graad = value;
            }
        }

        public override decimal BasisKostprijsPerDag
        {
            get { return BasisKostprijsPerDag; }
            set { BasisKostprijsPerDag = value; }
        }

       

        //constructor
        public CabinePersoneel(string personeelsId, string naam, Graad value, string werkpositie, decimal basiskostprijs, List<Certificaat> cerificaten)
        {
            PersoneelsId = personeelsId;
            Naam = naam;
            BasisKostprijsPerDag = basiskostprijs;
            Certificaten = cerificaten;
            Werkpositie = werkpositie;
        }

        //Method
        public override decimal BerekenTotaleKostprijsPerDag()
        {
          decimal Salaris;
                  if (Graad == Graad.Purser)
                  {
                      Salaris = BasisKostprijsPerDag * 1.2M;
                  }
                  else //(Type == Graad.Steward)
                  {
                      Salaris = BasisKostprijsPerDag;
                  }
            if (Certificaten.Any(c => c.CertificaatAfkorting.Equals("EHBO"))) Salaris += 5;
            return Salaris;
        }
        public override void Afbeelden()
        {
            Console.WriteLine(PersoneelsId + ": " + Naam + " - " + Graad);
            Console.WriteLine("Certificaten: " + Certificaten);
            Console.WriteLine("Werkpositie: " + Werkpositie);
        }
    }
}

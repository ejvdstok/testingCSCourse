using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FLYNET.Personeel
{
    public class CockpitPersoneel : VliegendPersoneel
    {
        private Graad graad;
        public decimal Salaris;
        // vlieguren int
        public int Vlieguren { get; set; }

        //graad: captain, seniorflightofficer, secondofficer, juniorflightofficer
        public override Graad Graad 
        {
            get { return graad; }
            set
            {
                if (!Enum.IsDefined(typeof(Graad), value))
                {
                    throw new Exception("Deze graad bestaad niet");
                }
                else if (value != Graad.Captain || value != Graad.SeniorFlightOfficer ||
                    value != Graad.SecondOfficer || value != Graad.JuniorOfficer)
                {
                    throw new Exception($"Personen met deze graad werken niet in de cockpit ({value.ToString()})");
                }
                graad = value;
            }
        }

        // verkeerde graad geeft exeption.
        //kostprijs per dag zie text
        public override decimal BasisKostprijsPerDag { get; set; }


        //constructor
        public CockpitPersoneel(string personeelsId, string naam, Graad graad, int vlieguren, decimal basiskostprijs, List<Certificaat> cerificaten)
        {
            PersoneelsId = personeelsId;
            Naam = naam;
            Vlieguren = vlieguren;
            BasisKostprijsPerDag = basiskostprijs;
            Certificaten = cerificaten;
           
        }


        //Method
        public override decimal BerekenTotaleKostprijsPerDag() //!!!SWITCH VAN MAKEN
        {
            switch (Graad)
            {
                case Graad.Captain:
                    Salaris = BasisKostprijsPerDag * 1.3M;
                    break;
                case Graad.SeniorFlightOfficer:
                    Salaris = BasisKostprijsPerDag * 1.2M;
                    break;
                case Graad.SecondOfficer:
                    Salaris = BasisKostprijsPerDag * 1.1M;
                    break;
                default:
                    Salaris = BasisKostprijsPerDag;
                    break;
            }

            if (Certificaten.Any(c => c.CertificaatAfkorting.Equals("CPL"))) Salaris += 50;
            return Salaris;
        }
        public override void Afbeelden()
        {
            Console.WriteLine(PersoneelsId + ": " + Naam + " - " + Graad);
            Console.WriteLine("Certificaten: " + Certificaten);
            Console.WriteLine("Vlieguren: " + Vlieguren);
            Console.WriteLine("Kostprijs voor deze vlucht: " + Salaris);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FLYNET.Personeel
{
    class CockpitPersoneel : VliegendPersoneel
    {
        private Graad graad;
        // vlieguren int
        public int Vlieguren
        {
            get { return Vlieguren; }
            set { Vlieguren = value; }
        }

        //graad: captain, seniorflightofficer, secondofficer, juniorflightofficer
        public Graad Functie
        {
            get { return graad; }
            set
            {
                if (!Enum.IsDefined(typeof(VliegendPersoneel.Graad), value))
                {
                    Console.WriteLine("Deze graad bestaad niet");
                }
                else if (value != VliegendPersoneel.Graad.Captain || value != VliegendPersoneel.Graad.SeniorFlightOfficer ||
                    value != VliegendPersoneel.Graad.SecondOfficer || value != VliegendPersoneel.Graad.JuniorFlightOfficer)
                {
                    Console.WriteLine("Personen met deze graad werken niet in de cockpit.");
                }
                graad = value;
            }
        }
        // verkeerde graad geeft exeption.
        //kostprijs per dag zie text
        public override decimal BasisKostprijsPerDag
        { 
            get;
            set;
        }

        public override decimal TotaleKostprijsPerDag
        {
            get
            {
                decimal Salaris;
                if (Functie == Graad.Captain)
                {
                    Salaris = BasisKostprijsPerDag * 1.3M;
                }
                if (Functie == Graad.SeniorFlightOfficer)
                {
                    Salaris = BasisKostprijsPerDag * 1.2M;
                }
                if (Functie == Graad.SecondOfficer)
                {
                    Salaris = BasisKostprijsPerDag * 1.1M;
                }
                else //(Functie == Graad.JuniorFlightOfficer)
                {
                    Salaris = BasisKostprijsPerDag;
                }
                if (HasCertificate("CLP"))
                { Salaris = Salaris + 50m; }
                return Salaris;
            }
        }

        //constructor
        public CockpitPersoneel(string personeelsId, string naam, Graad value, int vlieguren, decimal basiskostprijs, List<Certificate> cerificaten)
        {
            PersoneelsId = personeelsId;
            Naam = naam;
            Vlieguren = vlieguren;
            BasisKostprijsPerDag = basiskostprijs;
            Certificates = cerificaten;
        }

    }
}

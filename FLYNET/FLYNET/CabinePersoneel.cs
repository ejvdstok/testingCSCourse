﻿using System;
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
            set {
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
        private int Bonus;
        private int Salaris;

        public override decimal TotaleKostprijsPerDag
        {
            get
            {
                if (Type == Graad.Pulser)
                {
                    Bonus = BasisKostprijsPerDag * 0.2;
                    Salaris = BasisKostprijsPerDag + Bonus;
                    return Salaris;
                }
                if (Type == Graad.Steward)
                { 
                    return BasisKostprijsPerDag;
                }
            }

        }

    // 5€ extra voor ehbo certificaat

    //constructor
    public CabinePersoneel (string personeelsId, string naam, Graad value, string werkpositie, decimal basiskostprijs)
         {
         PersoneelsId = personeelsId;
        Naam = naam;
        Werkpositie = werkpositie;
        BasisKostprijsPerDag = basiskostprijs;
         }
    }
}

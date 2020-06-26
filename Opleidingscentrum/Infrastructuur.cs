using System;
using System.Collections.Generic;
using System.Text;

namespace Opleidingscentrum
{
        class Infrastructuur : IKost
        {
            //private fields
            private decimal huurprijsValue;
            //properties
            public string Naam
            {
                get; set;
            }

            public decimal Huurprijs
            {
                get { return huurprijsValue; }
                set
                {
                    if (value <= 0) Console.WriteLine("huurprijs moet kan niet negatief zijn");
                    else huurprijsValue = value;
                }
            }
            public decimal MaandKost
            {
                get { return Huurprijs; }
            }
            //constructors
            public Infrastructuur(string naam, decimal huurprijs)
            {
                Naam = naam;
                Huurprijs = huurprijs;
            }
            //methods
            public void Afbeelden()
            {
                Console.WriteLine("\nGebouw " + Naam + "\nHuurprijs per maand: " + Huurprijs
                    + "\nMaandelijkse kost: " + MaandKost + "\n");
            }
        }
}


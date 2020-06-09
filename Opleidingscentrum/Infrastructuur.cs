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
            set { if (value <= 0) Console.WriteLine("huurprijs moet kan niet negatief zijn");
                else huurprijsValue = value; }
        }
        public decimal MaandKost 
        { 
            get { return MaandKost; }
            set { MaandKost = (Huurprijs * 0.6m); }
        }
        //constructors
        public Infrastructuur (string naam, decimal huurprijs, decimal maandKost)
        {
            Naam = naam;
            Huurprijs = huurprijs;
            MaandKost = maandKost;
        }
        //methods
        public void GegevensTonen()
        {
            Console.WriteLine("Gebouw " + Naam + "Huurprijs per maand: " + Huurprijs
                + "\nMaandelijkse kost: " + MaandKost);
        }
    }
}

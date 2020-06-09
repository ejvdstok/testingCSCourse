using System;
using System.Collections.Generic;
using System.Text;

namespace Opleidingscentrum
{
    abstract class Personeelsleden : IKost
    {
        //private fields
        private readonly int PersoneelsnummerValue;
        private string FamilienaamValue;
        private string VoornaamValue;

        //Properties
        public int Personeelsnummer
        {
            get; set;
        }
        public string Familienaam
        {
            get { return FamilienaamValue; }
            set { FamilienaamValue = value; }
        }
        public string Voornaam
        {
            get { return VoornaamValue; }
            set { VoornaamValue = value; }
        }
        public decimal Maandloon
        {
            get { return Maandloon; }
            set { Maandloon = value; }
        }
        public decimal MaandKost
        {
            get { return MaandKost; }
            set { MaandKost = (Maandloon * 0.6m); }
        }
        //Methods

        public abstract void GegevensTonen();
    }
}

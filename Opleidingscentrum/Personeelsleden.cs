using System;
using System.Collections.Generic;
using System.Text;

namespace Opleidingscentrum
{
    abstract class  Personeelsleden : IKost
    {
        //private fields
        private int PersoneelsnummerValue;
        private string FamilienaamValue;
        private string VoornaamValue;
        private decimal MaandLoonValue;
        private Richting richtingValue;

        //Properties

        public int Personeelsnummer
        {
            get { return PersoneelsnummerValue; }
            set
            {
                PersoneelsnummerValue++;
            }
        }

        public string Familienaam
        {
            get { return FamilienaamValue; }
            set
            {
                if (value == string.Empty) Console.WriteLine("Gelieve een familienaam in te geven.");

                else FamilienaamValue = value;
            }
        }
        public string Voornaam
        {
            get { return VoornaamValue; }
            set
            {
                if (value == string.Empty) Console.WriteLine("Gelieve een voornaam in te geven.");

                else VoornaamValue = value; }
        }
        public decimal Maandloon
        {
            get { return MaandLoonValue; }
            set {
                if (value <= 0) Console.WriteLine("Het loon moet een positief getal zijn.");
                else MaandLoonValue = value; }
        }
        public decimal MaandKost
        {
            get { return Maandloon * 0.6M; }
        }
        public Richting Richting
        {
            get { return richtingValue; }
            set { richtingValue = value; }
        
        }
        //contrustor voor test
        /*public Personeelsleden(string familienaam, string voornaam, decimal maandloon)
        {
            Familienaam = familienaam;
            Voornaam = voornaam;
            Maandloon = maandloon;
        }*/
        //Methods

        public abstract void Afbeelden();
    }
}

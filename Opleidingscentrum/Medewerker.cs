using System;
using System.Collections.Generic;
using System.Text;

namespace Opleidingscentrum
{
    class Medewerker : Personeelsleden
    {
        //private fields
        private int AantalCursistenValue;

        //properties
        public int AantalCursisten
        {
            get { return AantalCursistenValue; }
            set { AantalCursistenValue = value; }
        }
        //Contrustors
        public Medewerker(string familienaam, string voornaam, decimal maandloon, int aantalCursisten)
        { 
            Familienaam = familienaam;
            Voornaam = voornaam;
            Maandloon = maandloon;
            AantalCursisten = aantalCursisten;
        }
        //Methods
        public override void Afbeelden()
        {
            Console.WriteLine("Personeelsnummer: " + Personeelsnummer + "\nNaam: " + Voornaam +" " + Familienaam
                + "\nBrutomaandloon:" + Maandloon + "\n Aantal cursisten: " + AantalCursisten + "\nMaandelijkse kost: " + MaandKost
                + "\n"); ;
        }
    }
}

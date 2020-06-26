using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Opleidingscentrum
{
    class Instructeur : Personeelsleden
    {
        //private fields
        private string emailadres;
        //properties
        public string Emailadres
        {
            get { return emailadres; }
            set
            {
                if (value.Contains("@") == true)
                { emailadres = value; }
                else { emailadres = "geen e-mail ingegeven"; }
            }
        }

        //Contrustors
        public Instructeur (string familienaam, string voornaam, decimal maandloon, string emailadres, Richting richting )
        {
            Voornaam = voornaam;
            Familienaam = familienaam;
            Maandloon = maandloon;
            Emailadres = emailadres;
            Richting = richting;
        }
        //Methods
        public override void Afbeelden()
        {
           Console.WriteLine("Personeelsnummer: " + Personeelsnummer + "\nNaam: " + Voornaam + " " + Familienaam
           + "\nBrutomaandloon:" + Maandloon + "\nInstructeur " + Richting + " : " + Emailadres + "\nMaandelijkse kost: "
           + MaandKost+ "\n");
        }
    }
}

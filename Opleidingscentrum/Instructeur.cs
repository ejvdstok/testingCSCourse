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
        private Richting richtingValue;
        //properties
        public string Emailadres
        {
            get { return emailadres; }
            set
            {
                if (value.Contains ("@") == true)
                     { emailadres = value; }
                else { emailadres = "geen e-mail ingegeven"; }
            }
        }
        public Richting Richting
        {
            get { return richtingValue; }
            set { richtingValue = value; }
        }
        //Contrustors
        public Instructeur (int personeelsnummer, string familienaam, string voornaam,
            decimal maandloon, string emailadres, Richting richting )
        {
            Emailadres = emailadres;
        }
        //Methods
        public override void GegevensTonen()
        {
           Console.WriteLine("Personeelsnummer: " + Personeelsnummer + "\nNaam: " + Voornaam + Familienaam
           + "\nBrutomaandloon:" + Maandloon + "\nInstructeur "+Richting+ " : " + Emailadres + "\nMaandelijkse kost: "
           + MaandKost);
        }
    }
}

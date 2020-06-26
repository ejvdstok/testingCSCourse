using System;
using System.Collections.Generic;
using System.Text;

namespace Opleidingscentrum
{ 
    class Richting
    {
        private string naamValue;
        
        public string Naam
        {
            get { return naamValue; }
            set { naamValue = value; }
        }
        public Richting(string naam)
        {
            Naam = naam;
        }
        public override string ToString()
        {
            return Naam;
        }
    }
}

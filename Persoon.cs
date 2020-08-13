using System;
using System.Collections.Generic;
using System.Linq;

namespace TTDtestLibrary
{
    public class Persoon
    {
        private List<string> voornamen;
        public Persoon(List<string> voornamen)
        {

            if (voornamen.Count < 1 || voornamen == null)
                throw new ArgumentException("Te weinig voornamen ingegeven");

            foreach (var voornaam in voornamen)
            {
                if (voornaam.Length < 1)
                {
                    throw new ArgumentException("Lege voornaam ingegeven");
                } 
            }
            /*if (voornamen != voornamen.Distinct().ToList())
            {
                throw new ArgumentException("Dezelfde naam kan geen twee keer voorkomen");
            }*/
            this.voornamen = voornamen;
        }
        public override string ToString()
        {
            return String.Join(" ", this.voornamen);
        }
    }
}


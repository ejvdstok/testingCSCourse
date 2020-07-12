using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace FLYNET.Personeel
{
    public abstract class VliegendPersoneel : Personeelslid
    {
       
        // Enum - Graad
        public abstract Graad Graad { get; set; }
        // code in afgeleide classes.

        public List<Certificaat> Certificaten { get; set; }
        //add in programma

        public override decimal BasisKostprijsPerDag
        { get; set;}

        //method 
        abstract public override decimal BerekenTotaleKostprijsPerDag();
        abstract public void Afbeelden();

    }
}

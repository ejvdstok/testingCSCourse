using FLYNET.Personeel;
using System;
using System.Collections.Generic;
using System.Text;

namespace FLYNET.Vloot
{
    class Vlucht
    {

        public int VluchtID;
        public string Bestemming;
        public int DuurtijdinDagen;
        //vliegmaatschappij uit andere class
        public readonly VliegMaatschappij vliegmaatschappij;
        //Toestel, passagiers of vracht.
        public Luchtvaartuig Toestel;
        //Personeel
        public List<VliegendPersoneel> personeel;
        public decimal vluchtkost;
        //method
        BerekenVluchtKost();//kost vliegtuig * aantal dagen
          { personeel TotaleKostprijsPerDag + vliegmaatschappij TotaleKostprijsPerDag * DuurtijdinDagen;}
    }
}

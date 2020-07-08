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
        public List<VliegendPersoneel> Personeel;
        public readonly VliegMaatschappij.VliegMaatschappijNaam vliegMaatschappij;
        //constructor
        public Vlucht(int id, string bestemming, vliegmaatschappij value, Luchtvaartuig toestel, int duurTijd, VliegendPersoneel bemanning)
        {
            VluchtID = id;
            Bestemming = bestemming;
            DuurtijdinDagen = duurTijd;
            vliegMaatschappij = vliegmaatschappij;
        }

        //method
        decimal BerekenVluchtKost()
        {
               decimal vluchtkost = 0;
               decimal airplanecosts;
            foreach (var people in Personeel)
            {
                vluchtkost = vluchtkost + people.TotaleKostprijsPerDag; 
            }
                airplanecosts = Toestel.BasisKostprijsPerDag;

            vluchtkost = (vluchtkost + airplanecosts) * DuurtijdinDagen;
            return vluchtkost;
        }
    }
}


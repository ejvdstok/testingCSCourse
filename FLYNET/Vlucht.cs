using FLYNET.Personeel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FLYNET.Vloot
{
    public class Vlucht 
    {

        public int VluchtID;
        public string Bestemming;
        public int DuurtijdinDagen = 0;
        public decimal BasisKostprijsVlucht;

        //vliegmaatschappij uit andere class
        public readonly VliegMaatschappij maatschappij;
        //Toestel, passagiers of vracht.
        public Luchtvaartuig Toestel;
        //Personeel
        public List<VliegendPersoneel> Personeel;
        //constructor
        public Vlucht(int id, string bestemming, VliegMaatschappij maatschappij, Luchtvaartuig toestel, int duurTijd, List <VliegendPersoneel> bemanning)
        {
            VluchtID = id;
            Bestemming = bestemming;
            DuurtijdinDagen = duurTijd;
        }
        
        public decimal BerekenVluchtKost()
        {
            decimal vluchtkost = 0;

            //De kostprijs bestaat uit 3 elementen:
            // De totale kost van het gebruikte toestel (1 toestel)
            vluchtkost += Toestel.BerekenTotaleKostprijsPerDag();
            // De personeelskost(kost van cockpit-en cabinepersoneel) (meerder personeelsleden: Beter Linq gebruiken ipv foreach)
            vluchtkost += Personeel.Select(p => p.BerekenTotaleKostprijsPerDag()).Sum();
            //De duurtijd(aantal dagen) van de vlucht
            vluchtkost *= DuurtijdinDagen;
            return vluchtkost;

        }
    }
}


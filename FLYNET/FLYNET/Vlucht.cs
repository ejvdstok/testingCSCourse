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
        public readonly VliegMaatschappij.VliegMaatschappijNaam Maatschappij;
        //Toestel, passagiers of vracht.
        public Luchtvaartuig TypeVliegtuig;
        public string  Model;
        //Personeel
        public List<VliegendPersoneel> Personeel;
        //constructor
        public Vlucht(int id, string bestemming, VliegMaatschappij.VliegMaatschappijNaam maatschappij, Luchtvaartuig typevliegtuig, int duurTijd, List <VliegendPersoneel> bemanning)
        {
            VluchtID = id;
            Bestemming = bestemming;
            Maatschappij = maatschappij;
            DuurtijdinDagen = duurTijd;
            TypeVliegtuig = typevliegtuig;
            Personeel = bemanning;
        }
        public decimal vluchtprijs = 0;
        public decimal BerekenVluchtKost()
        {
            //De kostprijs bestaat uit 3 elementen:
            // De totale kost van het gebruikte toestel (1 toestel)
            vluchtprijs += TypeVliegtuig.BerekenTotaleKostprijsPerDag();
            // De personeelskost(kost van cockpit-en cabinepersoneel) (meerder personeelsleden: Beter Linq gebruiken ipv foreach)
            vluchtprijs += Personeel.Select(p => p.BerekenTotaleKostprijsPerDag()).Sum();
            //De duurtijd(aantal dagen) van de vlucht
            vluchtprijs *= DuurtijdinDagen;
            return vluchtprijs;

        }
    }
}


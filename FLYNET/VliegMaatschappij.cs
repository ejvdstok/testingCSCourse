using System;
using System.Collections.Generic;
using System.Text;

namespace FLYNET.Vloot
{
    class VliegMaatschappij
    {
        public int VliegMaatschappijID;
        public enum VliegMaatschappijNaam
        { 
            BrusselsAirlines, Jetairfly, ThomasCook, TNTAirways
        }
        //vloot in programma
        
        public VliegMaatschappij(int vliegid, VliegMaatschappijNaam value, List<Luchtvaartuig> vliegtuig)
        {
            VliegMaatschappijID = vliegid;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FLYNET.Vloot
{
    class VliegMaatschappij
    {
        public int VliegMaatschappijID;
        public enum VliegMaatschappijNaam
        { BrusselsAirlines, Jetairfly, ThomasCook, TNTAirways}
        //vloot list
        
        public VliegMaatschappij(int vliegid, VliegMaatschappijNaam value, Luchtvaartuig vliegtuig)
        {
            VliegMaatschappijID = vliegid;
        }
    }
}

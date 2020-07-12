using System;
using System.Collections.Generic;
using System.Text;

namespace FLYNET.Vloot
{
    public class VliegMaatschappij
    {
        public int VliegMaatschappijID;
        public List<Luchtvaartuig> Vloot { get; set; }
        public enum VliegMaatschappijNaam
        { 
            BrusselsAirlines, Jetairfly, ThomasCook, TNTAirways
        }


        public VliegMaatschappij(int vliegid, VliegMaatschappijNaam value, List<Luchtvaartuig> vliegtuig)
        {
            VliegMaatschappijID = vliegid;
        }
    }
}

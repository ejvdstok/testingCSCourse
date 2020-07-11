using System;
using System.Collections.Generic;
using System.Text;

namespace FLYNET.Vloot
{
    public abstract class Luchtvaartuig : IKost
    {
        public string TypeVliegtuig;
        public string NaamVliegtuig;
        public int Kruissnelheid;
        public int VliegBereik;

        public abstract decimal BasisKostprijsPerDag { get; set; }

        public abstract decimal BerekenTotaleKostprijsPerDag();
        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FLYNET
{
    public interface IKost
    {
        decimal BasisKostprijsPerDag
        { get; set; }

        public decimal BerekenTotaleKostprijsPerDag();
        
    }
}

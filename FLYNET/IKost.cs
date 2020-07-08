using System;
using System.Collections.Generic;
using System.Text;

namespace FLYNET
{
    interface IKost
    {
        decimal BasisKostprijsPerDag
        { get; set; }

        decimal TotaleKostprijsPerDag
        { get; }
    }
}

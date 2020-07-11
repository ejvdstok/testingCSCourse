using System;
using System.Collections.Generic;
using System.Text;

namespace FLYNET.Personeel
{
    public abstract class Personeelslid : IKost
    {

        public string PersoneelsId { get; set;}
        public string Naam  { get;   set;}

        public abstract decimal BasisKostprijsPerDag { get; set; }

        public abstract decimal BerekenTotaleKostprijsPerDag();

    }
}

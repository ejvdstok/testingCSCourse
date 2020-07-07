using System;
using System.Collections.Generic;
using System.Text;

namespace FLYNET.Personeel
{
    abstract class Personeelslid : IKost
    {
        private string IdValue;
        private string NaamValue;

        public string PersoneelsId
        {
            get { return IdValue; }
            set { IdValue = value; }
        }
    public string Naam
        {
            get { return NaamValue; }
            set
            {
                if (value == string.Empty) Console.WriteLine("Gelieve een naam in te geven.");
                else NaamValue = value;
            }
        }

        public abstract decimal BasisKostprijsPerDag { get; set; }

        public abstract decimal TotaleKostprijsPerDag { get; }


    }
}

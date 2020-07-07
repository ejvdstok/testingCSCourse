using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace FLYNET.Personeel
{
    class VliegendPersoneel : Personeelslid
    {
        // Enum - Graad
        public enum Graad
        {
            Captain, SeniorFlightOfficer, SecondOfficer, JuniorFlightOfficer, Steward, Pulser
        }
        // code in afgeleide classes.

        //certificaten (controle in losse class)

        protected List<Certificate> Certificates;
        //add 
        //check

        public override decimal BasisKostprijsPerDag
        { get;
            set;
        }

        public override decimal TotaleKostprijsPerDag
        {
            get { return BasisKostprijsPerDag; }
        }

        //method
        public bool HasCertificate(string afkorting)
        {
            // heeft persoon certificaat type input?
            foreach (var certificate in Certificates)
            {
                if (afkorting == certificate.CertificaatAfkorting)
                { return true; }
            }
            return false;
        }
    }
}

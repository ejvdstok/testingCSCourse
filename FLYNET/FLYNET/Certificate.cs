using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace FLYNET.Personeel
{
    class Certificate
    {

        public string CertificaatAfkorting;

        public string CertificaatOmschrijving;

        // constructr
        public Certificate(string certficaatafkorting, string certificaatomschrijving)
        {
            CertificaatAfkorting = certficaatafkorting;
            CertificaatOmschrijving = certificaatomschrijving;
        }

        public static Certificate PPL = new Certificate
            ("PPL", "Private Pilot Licence");
        public static Certificate ATPL = new Certificate
            ("ATPL","Airline Transport Pilot Licence");
        public static Certificate IR = new Certificate
            ("IR","Instrument Rating");
        public static Certificate CPL = new Certificate
            ("CPL","Commercial Pilot License");
        public static Certificate ME = new Certificate
            ("ME","Multi Engine");
        public static Certificate MCC = new Certificate
            ("MCC","Multi Crew Concept");
        public static Certificate EHBO = new Certificate
            ("EHBO","First Aid");
        public static Certificate EVAC = new Certificate
            ("EVAC","Evacuation Procedures");
        public static Certificate FIRE = new Certificate
            ("FIRE","Fire Fighting");
        public static Certificate SURV = new Certificate
            ("SURV","Survival");
        public static Certificate IFS = new Certificate
            ("IFS","In Flight Service");
    }
}

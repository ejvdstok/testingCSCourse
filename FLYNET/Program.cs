using FLYNET.Personeel;
using FLYNET.Vloot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FLYNET
{
    class Program
    {
        static void Main(string[] args)
        { 
            Luchtvaartuig AirbusA319 = new PassagiersVliegtuig("AirbusA319", 880, 6850, 141, 1000m);
            Luchtvaartuig Boeing737 = new PassagiersVliegtuig("Boeing737", 850, 12500, 190, 1500m);
            Luchtvaartuig Boeing787 = new PassagiersVliegtuig("Boeing787", 913, 15700, 330, 2000m);
            Luchtvaartuig AntonovAn30 = new VrachtVliegtuig("AntonovAn-30", 430, 1600, 8, 300m);
            Luchtvaartuig britishAerospace146 = new VrachtVliegtuig("BritishAerospace146", 750, 1600, 42, 600m);
            Luchtvaartuig antonovAn225 = new VrachtVliegtuig("AntonovAn-225", 800, 15400, 425, 1500m);

            //vliegtuig maatschappijen
            VliegMaatschappij BrusselsAirlines = new VliegMaatschappij(1, VliegMaatschappij.VliegMaatschappijNaam.BrusselsAirlines, new List<Luchtvaartuig>
            { AirbusA319,
                Boeing737,
                Boeing787,
                britishAerospace146
            });
            VliegMaatschappij TNTAirways = new VliegMaatschappij(2, VliegMaatschappij.VliegMaatschappijNaam.TNTAirways, new List<Luchtvaartuig>
            {   Boeing737,
                Boeing787,
            });
            VliegMaatschappij Jetairfly = new VliegMaatschappij(3, VliegMaatschappij.VliegMaatschappijNaam.Jetairfly, new List<Luchtvaartuig>
            { AirbusA319,
                Boeing737,
                britishAerospace146
            });
            VliegMaatschappij ThomasCook = new VliegMaatschappij(4, VliegMaatschappij.VliegMaatschappijNaam.ThomasCook, new List<Luchtvaartuig>
            { AirbusA319,
                Boeing787,
            });

            List<Certificaat> Certificaten;
            Certificaat PPL = new Certificaat
            {
                CertificaatAfkorting = "PPL",
                CertificaatOmschrijving = "Private Pilot License"
            };

            Certificaat ATPL = new Certificaat
            {
                CertificaatAfkorting = "ATPL",
                CertificaatOmschrijving = "Airline Transport Pilot License"
            };

            Certificaat IR = new Certificaat
            {
                CertificaatAfkorting = "IR",
                CertificaatOmschrijving = "Instrument Rating"
            };

            Certificaat CPL = new Certificaat
            {
                CertificaatAfkorting = "CPL",
                CertificaatOmschrijving = "Commercial Pilot License"
            };

            Certificaat ME = new Certificaat
            {
                CertificaatAfkorting = "ME",
                CertificaatOmschrijving = "Multi Engine"
            };

            Certificaat MCC = new Certificaat
            {
                CertificaatAfkorting = "MCC",
                CertificaatOmschrijving = "Multi Crew Concept"
            };

            Certificaat EHBO = new Certificaat
            {
                CertificaatAfkorting = "EHBO",
                CertificaatOmschrijving = "First Aid"
            };

            Certificaat EVAC = new Certificaat
            {
                CertificaatAfkorting = "EVAC",
                CertificaatOmschrijving = "Evacution Procedures"
            };

            Certificaat FIRE = new Certificaat
            {
                CertificaatAfkorting = "FIRE",
                CertificaatOmschrijving = "Fire Fighting"
            };

            Certificaat SURV = new Certificaat
            {
                CertificaatAfkorting = "SURV",
                CertificaatOmschrijving = "Survival"
            };

            Certificaat IFS = new Certificaat
            {
                CertificaatAfkorting = "IFS",
                CertificaatOmschrijving = "In Flight Service"
            };

            
                VliegendPersoneel captKirk = new CockpitPersoneel("001", "Capitain Kirk", Graad.Captain, 5000, 500,
                    new List<Certificaat> {
                PPL, ATPL, CPL, SURV});
                VliegendPersoneel Spock = new CockpitPersoneel("002", "Spock", Graad.SecondOfficer, 4500, 400,
                    new List<Certificaat> {
                PPL, ATPL, CPL, IFS
                });
                VliegendPersoneel McCoy = new CockpitPersoneel("003", "McCoy", Graad.SeniorFlightOfficer, 4500, 400,
                    new List<Certificaat> {
                PPL, ATPL, CPL, SURV
                });
                VliegendPersoneel PChekov = new CabinePersoneel("004", "Pavel Chekov", Graad.Purser, "deur1", 300,
                    new List<Certificaat> {
                ME, MCC, EHBO, IFS
                });
                VliegendPersoneel HSulu = new CabinePersoneel("005", "Hikaru Sulu", Graad.Steward, "deur2", 300,
                    new List<Certificaat> {
                ME, MCC, FIRE, SURV, IFS
                });
                VliegendPersoneel SkyWalker = new CabinePersoneel("006", "Skywalker", Graad.Steward, "nooduitgang", 300,
                    new List<Certificaat> {
                EHBO, FIRE, SURV, IFS
                });

                // array van vluchten
                Vlucht[] vluchten = new Vlucht[5];

                vluchten[0] = new Vlucht(1, "New York", VliegMaatschappij.VliegMaatschappijNaam.BrusselsAirlines, Boeing787, 2, new List<VliegendPersoneel>
                 {captKirk, Spock, PChekov, HSulu,});
                vluchten[1] = new Vlucht(2, "Beijing", VliegMaatschappij.VliegMaatschappijNaam.TNTAirways, antonovAn225, 1, new List<VliegendPersoneel>
                  {captKirk, SkyWalker,});
                vluchten[2] = new Vlucht(3, "Sydney", VliegMaatschappij.VliegMaatschappijNaam.ThomasCook, AirbusA319, 3, new List<VliegendPersoneel>
                  {captKirk, Spock, PChekov, HSulu,});
                vluchten[3] = new Vlucht(4, "Singapore", VliegMaatschappij.VliegMaatschappijNaam.BrusselsAirlines, britishAerospace146, 2, new List<VliegendPersoneel>
                {McCoy, HSulu, SkyWalker});
                vluchten[4] = new Vlucht(5, "Malta", VliegMaatschappij.VliegMaatschappijNaam.Jetairfly, Boeing737, 1, new List<VliegendPersoneel>
                 {captKirk, Spock, SkyWalker});

                Console.WriteLine();

                //checken op vrachtvluchten
                    Console.WriteLine("Vrachtvluchten");
                    var vrachtvluchten = vluchten.Where(v => v.TypeVliegtuig.GetType() == typeof(VrachtVliegtuig));
            foreach (var vlucht in vrachtvluchten)
            {
                vlucht.BerekenVluchtKost();
                        
                Console.WriteLine($"{vlucht.VluchtID}: {vlucht.Bestemming} ( {vlucht.Maatschappij} ) - {vlucht.TypeVliegtuig} - vluchtprijs: {vlucht.vluchtprijs}");
                Console.WriteLine("------------------------------------------------------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("Cockpit personeel.");
                Console.WriteLine(" ");

                var cockpit = vlucht.Personeel.Where(p => p.GetType() == typeof(CockpitPersoneel));
                foreach (var foo in cockpit)
                  {
                  foo.Afbeelden();
                  }
                   Console.WriteLine(" ");
                   Console.WriteLine("Cabine personeel: ");
                   Console.WriteLine("");
                   var cabine = vlucht.Personeel.Where(p => p.GetType() == typeof(CabinePersoneel));
                   foreach (var bar in cabine)
                     {
                     bar.Afbeelden();
                     }
                Console.WriteLine(" ");
            }
                    Console.WriteLine("Passagiersvluchten");
                    var passagiersvluchten = vluchten.Where(v => v.TypeVliegtuig.GetType() == typeof(PassagiersVliegtuig));
                    foreach (var vlucht in passagiersvluchten)
                    {
                         vlucht.BerekenVluchtKost();
                        Console.WriteLine($"{vlucht.VluchtID}: {vlucht.Bestemming} - ( {vlucht.Maatschappij} ) - {vlucht.TypeVliegtuig} - vluchtprijs: {vlucht.vluchtprijs}");
                        Console.WriteLine("------------------------------------------------------------------------------");
                        Console.WriteLine(" ");
                        Console.WriteLine("Cockpit personeel.");
                        Console.WriteLine(" ");

                        var cockpit = vlucht.Personeel.Where(p => p.GetType() == typeof(CockpitPersoneel));
                        foreach (var foo in cockpit)
                        {
                          foo.Afbeelden();
                          Console.WriteLine(" ");
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Cabine personeel: ");
                        Console.WriteLine("");
                        var cabine = vlucht.Personeel.Where(p => p.GetType() == typeof(CabinePersoneel));
                        foreach (var bar in cabine)
                        {
                            bar.Afbeelden();
                            Console.WriteLine("");
                        }
                        Console.WriteLine("");
                    }            
        }
        
    }
    
}



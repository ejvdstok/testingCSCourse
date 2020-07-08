using FLYNET.Personeel;
using FLYNET.Vloot;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FLYNET
{
    class Program
    {
        static void Main(string[] args)
        {
            VliegendPersoneel captKirk = new CockpitPersoneel("001", "Capitain Kirk", VliegendPersoneel.Graad.Captain, 5000, 500,
                new List<Certificate> {
                Certificate.PPL,
                Certificate.ATPL,
                Certificate.CPL,
                Certificate.SURV
            });
            VliegendPersoneel Spock = new CockpitPersoneel("002", "Spock", VliegendPersoneel.Graad.SecondOfficer, 4500, 400,
                new List<Certificate> {
                Certificate.PPL,
                Certificate.ATPL,
                Certificate.CPL,
                Certificate.IFS
            });
            VliegendPersoneel McCoy = new CockpitPersoneel("003", "McCoy", VliegendPersoneel.Graad.SeniorFlightOfficer, 4500, 400,
                new List<Certificate> {
                Certificate.PPL,
                Certificate.ATPL,
                Certificate.CPL,
                Certificate.SURV
            });
            VliegendPersoneel PChekov = new CabinePersoneel("004", "Pavel Chekov", VliegendPersoneel.Graad.Pulser, "deur1", 300,
                new List<Certificate> {
                Certificate.ME,
                Certificate.MCC,
                Certificate.EHBO,
                Certificate.IFS
            });
            VliegendPersoneel HSulu = new CabinePersoneel("005", "Hikaru Sulu", VliegendPersoneel.Graad.Steward, "deur2", 300,
                new List<Certificate> {
                Certificate.ME,
                Certificate.MCC,
                Certificate.FIRE,
                Certificate.SURV,
                Certificate.IFS
            });
            VliegendPersoneel SkyWalker = new CabinePersoneel("006", "Skywalker", VliegendPersoneel.Graad.Steward, "nooduitgang", 300,
                new List<Certificate> {
                Certificate.EHBO,
                Certificate.FIRE,
                Certificate.SURV,
                Certificate.IFS
            });
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
            // array van vluchten
            Vlucht[] vluchten = new Vlucht[5];

            vluchten[0] = new Vlucht(1, "New York", BrusselsAirlines, Boeing787, 2, new List<VliegendPersoneel>
            {captKirk,
            Spock,
            PChekov,
            HSulu,});
            vluchten[1] = new Vlucht(2, "Beijing", TNTAirways, antonovAn225, 1, new List<VliegendPersoneel>
            {captKirk,
            SkyWalker,});
            vluchten[2] = new Vlucht(3, "Sydney", ThomasCook, AirbusA319, 3, new List<VliegendPersoneel>
            {captKirk,
            Spock,
            PChekov,
            HSulu,});
            vluchten[3] = new Vlucht(4, "Singapore", BrusselsAirlines, britishAerospace146, 2, new List<VliegendPersoneel>
            {McCoy,
            HSulu,
            SkyWalker});
            vluchten[4] = new Vlucht(5, "Malta", Jetairfly, Boeing737, 1, new List<VliegendPersoneel>
            {captKirk,
            Spock,
            SkyWalker
            });

            Console.WriteLine();
            decimal TotaleKost = 0;

            //checken op vrachtvluchten
            foreach (Vlucht ritjes in vluchten)
            {
                Console.WriteLine("Vrachtvluchten");
                var vrachtvluchten = vluchten.Where(Luchtvaartuig == VrachtVliegtuig);
                foreach (var vlucht in vrachtvluchten)
                {
                    Console.WriteLine(Vlucht.VluchtID + ": " + Bestemming + " (" + VliegMaatschappij + ") - " + Toestel);
                    Console.WriteLine("------------------------------------------------------------------------------");
                    Console.WriteLine(" ");
                    Console.WriteLine("Cockpit personeel.");
                    Console.WriteLine(" ");
                    var cockpit = Personeel.Where(VliegendPersoneel == CockpitPersoneel);
                    foreach (var foo in cockpit)
                    {
                        Console.WriteLine(Personeelslid.PersoneelsId + ": " + Personeelslid.Naam + " - " + Personeelslid.Graad);
                        Console.WriteLine("Certificaten: " + VliegendPersoneel.certificate);
                        Console.WriteLine("Vlieguren: " + VliegendPersoneel);
                    }
                }


                /*  
                  TotaleKost += foo.TotaleKostprijsPerDag;*/

            }
            //nog maals nu op personenvluchten
        }
    }
}


﻿using FLYNET.Personeel;
using FLYNET.Vloot;
using System;
using System.Collections.Generic;

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
            VliegendPersoneel PChekov = new CabinePersoneel("004", "Pavel Chekov", VliegendPersoneel.Graad.Pulser, 300, 
                new List<Certificate> {
                Certificate.ME,
                Certificate.MCC,
                Certificate.EHBO,
                Certificate.IFS
            });
            VliegendPersoneel HSulu = new CabinePersoneel("005", "Hikaru Sulu", VliegendPersoneel.Graad.Steward, 300,
                new List<Certificate> {
                Certificate.ME,
                Certificate.MCC,
                Certificate.FIRE,
                Certificate.SURV,
                Certificate.IFS
            });
            VliegendPersoneel SkyWalker = new CabinePersoneel("006", "Skywalker", VliegendPersoneel.Graad.Steward, 300,
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
            VliegMaatschappij BrusselsAirlines = new VliegMaatschappij(1, 0, Boeing737);

            // array van vluchten
            Vlucht[] vluchten = new Vlucht[5];

            vluchten[0] = new Vlucht(1, "New York", BrusselsAirlines, Boeing787, 2, captKirk);
            vluchten[1] = new Vlucht(2, "Beijing", TNTAirways, antonovAn225, 1, captKirk);
            vluchten[2] = new Vlucht(3, "Sydney", ThomasCook, AirbusA319, 3, captKirk);
            vluchten[3] = new Vlucht(4, "Singapore", BrusselsAirlines, britishAerospace146, 2, McCoy);
            vluchten[4] = new Vlucht(5, "Malta", JetairFly, Boeing737, 1, captKirk);

        }
    }
}
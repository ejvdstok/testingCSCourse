using System;
using System.Runtime.InteropServices;

namespace Opleidingscentrum
{
    class Program
    {
        static void Main(string[] args)
        {
            Richting richting1 = new Richting("Ontwikkeling");
            Richting richting2 = new Richting("Netwerkbeheer");

            IKost[] voorwerpen = new IKost[5];

            voorwerpen[0] = new Instructeur("Jansen", "Jan", 1500m, "iets", richting1);
            voorwerpen[1] = new Instructeur("Roosen", "Roos",1600M, "roosroosen@vdab.be", richting1);
            voorwerpen[2] = new Medewerker("Peeters", "Piet", 1550M, 10);
            voorwerpen[3] = new Infrastructuur("Gebouw Einstein ", 1500M);
            voorwerpen[4] = new Infrastructuur("Gebouw Newton", 2500M);

            Console.WriteLine("Collectieve verlofperiode" );
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("verlofperiode kersmis: 25/12/2020 - 1/1/2021");
            Console.WriteLine("verlofperiode zomer: 1/7/2020 - 31/7/2020");
            Console.WriteLine();
            Console.WriteLine("Kosten personeel en infrasructuur");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();

            decimal totaleKost = 0;

            foreach (IKost kost in voorwerpen)
            {
                kost.Afbeelden();
                totaleKost += kost.MaandKost;
            }

            Console.WriteLine("\nTotale kosten= " + totaleKost);

            Console.WriteLine();
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
        }
    }
}

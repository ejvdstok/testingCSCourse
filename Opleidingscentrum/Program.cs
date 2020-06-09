using System;

namespace Opleidingscentrum
{
    class Program
    {
        static void Main(string[] args)
        {
            Richting richting1 = new Richting("Ontwikkeling");
            Richting richting2 = new Richting("Netwerkbeheer");

            IKost[] kosten = new IKost[1];

            kosten[1] = new Instructeur(1, "Puck", "Pietje", 1300m, "Ass@reet", richting1);

            Console.WriteLine();
            decimal totaleKost = 0m;

            foreach (IKost item in kosten)
            {
                item.GegevensTonen();
                totaleKost += item.MaandKost;
            }
            Console.WriteLine();
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
        }
    }
}

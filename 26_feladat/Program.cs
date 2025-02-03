using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            double szam1, szam2;

            Console.Write("Add meg az első számot: ");
            szam1 = double.Parse(Console.ReadLine());
            Console.Write("Add meg a második számot: ");
            szam2 = double.Parse(Console.ReadLine());

            if (szam2==0)
            {
                Console.WriteLine("Nullával osztani nem lehet!");
            }
            else if (szam1%szam2==0 && szam1!=0)
            {
                Console.WriteLine($"A {szam2} osztója a {szam1}-nak(nek)\nEredmény:{szam1/szam2} ");
            }
            else
            {
                Console.WriteLine($"A {szam2} nem osztója a {szam1}-nak(nek)");
            }

            Console.ReadKey();
        }
    }
}

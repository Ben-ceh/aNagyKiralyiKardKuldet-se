using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adj meg egy számot: ");
            int szam = int.Parse(Console.ReadLine());

            if (szam == 0)
            {
                Console.WriteLine($"A szám nulla.");
            }
            else if (szam%2==0)
            {
                Console.WriteLine($"A szám páros.");
            }
            else
            {
                Console.WriteLine($"A szám páratlan.");
            }

            Console.ReadKey();
        }
    }
}

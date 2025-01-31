using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adj meg egy számot: ");
            int szam = int.Parse(Console.ReadLine());

            if (szam%2==0)
            {
                Console.WriteLine($"A(z) {szam} páros.");
            }
            else
            {
                Console.WriteLine($"A(z) {szam} páratlan.");
            }

            Console.ReadKey();
        }
    }
}

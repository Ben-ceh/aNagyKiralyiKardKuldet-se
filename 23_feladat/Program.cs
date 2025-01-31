using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Add meg az első számot: ");
            int szam1 = int.Parse(Console.ReadLine());
            Console.Write("Add meg a második számot: ");
            int szam2 = int.Parse(Console.ReadLine());
            if (szam1 > szam2)
            {
                Console.WriteLine("Az első szám a nagyobb.");
                Console.WriteLine($"{szam1} - {szam2} = {szam1-szam2}");
            }
            else if (szam2 > szam1)
            {
                Console.WriteLine("A második szám a nagyobb.");
                Console.WriteLine($"{szam2} - {szam1} = {szam2 - szam1}");
            }
            else
            {
                Console.WriteLine("A két szám egyenlő.");
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Add meg a dolgozat pontszámát(0-100): ");
            int pontszam = int.Parse(Console.ReadLine());

            switch (pontszam)
            {
                case int i when i>0 && i<50:
                    Console.WriteLine("Elégtelen - 1");
                    break;
                case int i when i >=50 && i < 65:
                    Console.WriteLine("Elégséges - 2");
                    break;
                case int i when i >= 65 && i < 80:
                    Console.WriteLine("Közepes - 3");
                    break;
                case int i when i >= 80 && i < 90:
                    Console.WriteLine("Jó - 4");
                    break;
                case int i when i >= 90 && i <= 100:
                    Console.WriteLine("Kitűnő - 5");
                    break;

                default:
                    Console.WriteLine("Hibás pontszám!");
                    break;
            }

            Console.ReadKey();
        }
    }
}

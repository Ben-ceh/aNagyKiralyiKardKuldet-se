using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Add meg a nap számát: ");
            string nap = Console.ReadLine();

            switch (nap)
            {
                case "1":
                    Console.WriteLine("Hétfő");
                    break;
                case "2":
                    Console.WriteLine("Kedd");
                    break;
                case "3":
                    Console.WriteLine("Szerda");
                    break;
                case "4":
                    Console.WriteLine("Csütörtök");
                    break;
                case "5":
                    Console.WriteLine("Péntek");
                    break;
                case "6":
                    Console.WriteLine("Szombat");
                    break;
                case "7":
                    Console.WriteLine("Vasárnap");
                    break;
                default:
                    Console.WriteLine("Nincs ilyen nap!");
                    break;
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Add meg a hónap számát: ");
            int honap = int.Parse(Console.ReadLine());
            if (honap==3 || honap==4 || honap==5)
            {
                Console.WriteLine("Tavasz");
            }
            else if (honap == 6 || honap == 7 || honap == 8)
            {
                Console.WriteLine("Nyár");
            }
            else if (honap == 9 || honap == 10 || honap == 11)
            {
                Console.WriteLine("Ősz");
            }
            else if (honap == 12 || honap == 1 || honap == 2)
            {
                Console.WriteLine("Tél");
            }
            else
            {
                Console.WriteLine("Nincs ilyen hónap!");
            }

            Console.ReadKey();
        }
    }
}

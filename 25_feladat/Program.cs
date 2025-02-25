using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            double szam1, szam2, eredmeny = 0;
            Console.Write("Add meg az első számot: ");
            szam1 = double.Parse(Console.ReadLine());
            Console.Write("Add meg a második számot: ");
            szam2 = double.Parse(Console.ReadLine());
            if (szam1>szam2)
            {
                if (szam2==0)
                {
                    Console.WriteLine("Nullával nem osztunk!");
                }
                else
                {
                    eredmeny = szam1 / szam2;
                    Console.WriteLine($"Az eredmény: {eredmeny}");
                }
            }
            else if (szam2>szam1)
            {
                if (szam1==0)
                {
                    Console.WriteLine("Nullával nem osztunk!");
                }
                else
                {
                    eredmeny = szam2 / szam1;
                    Console.WriteLine($"Az eredmény: {eredmeny}");
                }
            }
            else
            {
                Console.WriteLine("A számok egyenlőek!");    
            }
            

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace melyikNagyobb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Add meg az első számot: ");
            int szam1 = int.Parse(Console.ReadLine());
            Console.Write("Add meg a második számot: ");
            int szam2 = int.Parse(Console.ReadLine());
            if (szam1>szam2)
            {
                Console.WriteLine("Az első szám a nagyobb.");
            }
            else
            {
                Console.WriteLine("A második szám a nagyobb.");
            }

            Console.ReadKey();
        }
    }
}

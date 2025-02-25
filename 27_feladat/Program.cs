using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Add meg a háromszög oldalait!");
            Console.Write("a oldal: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b oldal: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("c oldal: ");
            c = int.Parse(Console.ReadLine());

            if (a+b>c && b+c>a && c+a>b)
            {
                Console.WriteLine("A háromszög szerkeszthető");
            }
            else
            {
                Console.WriteLine("A háromszög nem szerkeszthető");
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kökbulma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" denklemin a, b ve c değerlerini giriniz: ");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double d = b * b - (4 * a * c);
            double x1, x2, x;

            if (d > 0)
            {
                x1 = (-b - (Math.Sqrt(d))) / 2 * a;
                x2 = (-b + (Math.Sqrt(d))) / 2 * a;
                Console.WriteLine("denkleminin 2 ayrı kökü vardır: ");
                Console.WriteLine("x1: " + x1);
                Console.WriteLine("x2: " + x2);
                Console.ReadLine();
            }
            else if (d == 0)
            {
                x = -b / 2 * a;
                Console.WriteLine(" denkleminin 1 kökü vardır : ");
                Console.WriteLine(" x: " + x);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("denkleminin kökü yoktur");
                Console.ReadLine();
            }
        }
    }
}
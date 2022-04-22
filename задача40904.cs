using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static double Med(double a,double b,double c)
        {
           return .5 * Math.Sqrt(2 * b * b + 2 * c * c - a * a);
        }
        static void Main(string[] args)
        {
            double a = 3, b = 4, c = 5;
            bool m=false;
            while (m != true) {
                if ((a + b < c) || (a + c < b) || (b + c < a))
                {
                    Console.WriteLine("Not exist!");
                    m = false;
                }
                else
                {
                    m = true;
                    Console.WriteLine(a + " " + b + " " + c + "\n");
                    double a1 = Med(a, b, c);
                    double b1 = Med(b, a, c);
                    double c1 = Med(c, a, b);
                    Console.WriteLine(a1 + " " + b1 + " " + c1 + "\n");
                    double a2 = Med(a1, b1, c1);
                    double b2 = Med(b1, a1, c1);
                    double c2 = Med(c1, a1, b1);
                    Console.WriteLine(a2 + " " + b2 + " " + c2 + "\n");
                    Console.ReadKey(true);
                }
            }
        }
    }
}

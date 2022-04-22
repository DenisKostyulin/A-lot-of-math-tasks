using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class задача2
    {
        static void Main(string[] args)
        {
            double a, b, x, eps = 1E-6, y;
            double fa, fc, c;
            int i;
            double pi = Math.PI;
            double e = Math.Exp(1);
            for (i = 0; i <= 200; i++)
            {
                x = -10;
                x = x + 0.1 * i;
                y = e * x * x * x - pi * x * x - 2 *e* x - x + 2 * pi;
                Console.WriteLine("y={0},x={1}", y, x);
            }
            Console.ReadLine();
            Console.WriteLine("Enter a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b");
            b = double.Parse(Console.ReadLine());
            do
            {
                c = (a + b) / 2;
                if (Math.Abs(e * c * c * c - pi * c * c - 2 * e * c - c + 2 * pi) < eps) break;
                fa = e * a * a * a - pi * a * a - 2 * e * a - a + 2 * pi;
                fc = e * c * c * c - pi * c * c - 2 * e * c - c + 2 * pi;
                if (fa * fc > 0)
                    a = c;
                else
                    b = c;
            } while (Math.Abs(fc) >= eps);
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}

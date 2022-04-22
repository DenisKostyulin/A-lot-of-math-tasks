using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class задача1
    {
        static void Main(string[] args)
        {
            double a, b, x, eps = 1E-6, y;
            double fa,fc, c;
            int i;
            double pi = Math.PI;
            double e = Math.Exp(1);
            for (i = 0; i <= 100; i++)
            {
                x = -10;
                x = x + 0.1 * i;
                y =pi*x*x*x-e*x*x+2*e*x+x+pi*pi;
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
                if (Math.Abs(pi * c * c * c - e * c * c + 2 * e * c + c +pi * pi) < eps) break;
                fa = pi * a * a * a - e * a * a + 2 * e * a + a + pi * pi;
                fc = pi * c * c * c - e * c * c + 2 * e * c + c + pi * pi;
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

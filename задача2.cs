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
            int n = 10, i;
            double eps = 1E-3, b = Math.PI, a = 0, s = 0, f1 = 0, f2 = 0, t, y, m = 0, h;
            y = Math.Cos(Math.Exp(0)) + Math.Cos(Math.Exp(b));
            do
            {
                f1 = 0;
                f2 = 0;
                t = s;
                m++;
                n = n * 2;
                h = (b - a) / n;
                for (i = 0; i <= n - 2; i = i + 2)
                {
                    f1 = Math.Cos(Math.Exp((a + (i + 1) * h))) + f1;
                    f2 = Math.Cos(Math.Exp((a + (i + 2) * h))) + f2;
                }
                f2 = f2 - Math.Exp(b);
                s =(y + 4 * f1 + 2 * f2) * (h / 3);
            } while (Math.Abs(t - s) > eps);
            Console.WriteLine(s);
            Console.WriteLine(t);
            Console.WriteLine(m);
            Console.ReadLine();
        }
    }
}

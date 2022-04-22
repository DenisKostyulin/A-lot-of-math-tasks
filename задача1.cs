using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class задача1
    {
        static void Main(string[] args)
        {
            int n = 10, i;
            double x = 4;
            double eps = 1E-6, b = x, a = 0, s = 0, f1 = 0, f2 = 0, t, y, m = 0,h,d1,d2;
            y = Math.Exp(0) + Math.Exp(-x*x/2);
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
                    d1 = (a + (i + 1) * h);
                    d2 = (a + (i + 2) * h);
                    f1 = Math.Exp(-d1*d1/2) + f1;
                    f2 = Math.Exp(-d1*d1/2) + f2;
                }
                f2 = f2 - Math.Exp(-x*x/2);
                s = (Math.Sqrt(2/Math.PI))*(y + 4 * f1 + 2 * f2) * (h / 3);
            } while (Math.Abs(t - s) > eps);
            Console.WriteLine(s);
            Console.WriteLine(t);
            Console.WriteLine(m);
            Console.ReadLine();
        }
    }
}

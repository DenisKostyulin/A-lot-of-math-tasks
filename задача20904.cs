using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class задача20904
    {
        static double Func(double x,double y,double z)
        {
            return (x - y - Math.Sin(z)) /(5+Math.Abs(z));
        }
        static void Main(string[] args)
        {
            double x = 3, y = 4;
            double res = Func(x, -2 * y, 1.17) + Func(2.2,x,y-x);
            Console.WriteLine(res);
            Console.ReadKey(true);
        }
    }
}

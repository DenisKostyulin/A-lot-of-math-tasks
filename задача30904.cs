using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class задача30904
    {
        static double Max(double x, double y)
        {
            if (x > y)
                return x; 
            else
                return y;
        }
        static void Main(string[] args)
        {
            double x = 3, y = 4, z = 5;
            double u = Max(x+y+z/3,x*x*y*y*z);
            Console.WriteLine(u*u*u-3);
            Console.ReadKey(true);
        }
    }
}

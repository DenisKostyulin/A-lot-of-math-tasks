using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class задача10904
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
            double x=4, y=5,z=6;
            Console.WriteLine((Max(x,x+y)+Max(x,y+z))/(1+Max(x+y*z,x+15)));
            Console.ReadKey(true);
        }
    }
}

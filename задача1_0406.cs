using System;

namespace ConsoleApp53
{
    class Program
    {
        static double Area(double[,]c)
        {
            double[] a = new double[3];
            a[0] = Math.Sqrt((c[0, 0] - c[1, 0]) * (c[0, 0] - c[1, 0]) + (c[0, 1] - c[1, 1]) * (c[0, 1] - c[1, 1]));
            a[1] = Math.Sqrt((c[1, 0] - c[2, 0]) * (c[1, 0] - c[2, 0]) + (c[1, 1] - c[2, 1]) * (c[1, 1] - c[2, 1]));
            a[2] = Math.Sqrt((c[2, 0] - c[0, 0]) * (c[2, 0] - c[0, 0]) + (c[2, 1] - c[0, 1]) * (c[2, 1] - c[0, 1]));
            double p = (a[0] + a[1] + a[2]) / 2;
            return Math.Sqrt(p * (p - a[0]) * (p - a[1]) * (p - a[2]));
        }
        static void Main(string[] args)
        {
            double[,] tr1 = new double[,]
            {
                {1,2 },{3,8 },{5,6 }
            };
            double[,] tr2 = new double[,]
            {
                {5,3 },{1,3 },{7,2 }
            };
            Console.WriteLine(Area(tr1));
            Console.WriteLine(Area(tr2));
            Console.ReadLine();
        }
    }
}

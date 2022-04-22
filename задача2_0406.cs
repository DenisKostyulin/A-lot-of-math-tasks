using System;

namespace ConsoleApp2
{
    class Program
    {
        static double Area(double[,] c)
        {
            if (c == null) throw new Exception("Площадь не может быть найдена!");
            double[] a = new double[3];
            a[0] = Math.Sqrt((c[0, 0] - c[1, 0]) * (c[0, 0] - c[1, 0]) + (c[0, 1] - c[1, 1]) * (c[0, 1] - c[1, 1]));
            a[1] = Math.Sqrt((c[1, 0] - c[2, 0]) * (c[1, 0] - c[2, 0]) + (c[1, 1] - c[2, 1]) * (c[1, 1] - c[2, 1]));
            a[2] = Math.Sqrt((c[2, 0] - c[0, 0]) * (c[2, 0] - c[0, 0]) + (c[2, 1] - c[0, 1]) * (c[2, 1] - c[0, 1]));
            double p = (a[0] + a[1] + a[2]) / 2;
            return Math.Sqrt(p * (p - a[0]) * (p - a[1]) * (p - a[2]));
        }
        static double[,] intersections(double[] p1,double[] p2 ,double[] p3)
        {
            if ((p1[0] / p1[1] == p2[0] / p2[1]) || (p1[0] / p1[1] == p3[0] / p3[1]) || (p2[0] / p2[1] == p3[0] / p3[1])) return null;

            double[,] P = new double[3,2];

            P[0, 0] = -(-p1[2]*p2[1]+p2[2]*p1[1]) / (p1[0]*p2[1]-p2[0]*p1[1]);
            P[0, 1] = -(-p1[0]*p2[2]+p2[0]*p1[2]) / (p1[0]*p2[1]-p2[0]*p1[1]);

            P[1, 0] = -(-p2[2] * p3[1] + p3[2] * p2[1]) / (p2[0] * p3[1] - p3[0] * p2[1]);
            P[1, 1] = -(-p2[0] * p3[2] + p3[0] * p2[2]) / (p2[0] * p3[1] - p3[0] * p2[1]);

            P[2, 0] = -(-p1[2] * p3[1] + p3[2] * p1[1]) / (p1[0] * p3[1] - p3[0] * p1[1]);
            P[2, 1] = -(-p1[0] * p3[2] + p3[0] * p1[2]) / (p1[0] * p3[1] - p3[0] * p1[1]);

            return P;
        }
        static void Main(string[] args)
        {
            double[] p1 = { 1, 2, 3};
            double[] p2 = { 2, 4, 2};
            double[] p3 = { 5, 3, 7};
            try
            {
                Console.WriteLine(Area(intersections(p1,p2,p3)));
            }
            catch(Exception e)
            {
                Console.WriteLine("Ошибка {0}",e.Message);
            }
            Console.ReadKey(true);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    class задача1_1704
    {
        static double MAX(double []x)
        {
            double max=x[0];
            for (int i=0;i<x.Length-1;i++)
            {
                max = max > x[i + 1] ?max:x[i+1]; 
            }
            return max;
        }
        static double MIN(double []x)
        {
            double min=x[0];
            for (int i=0;i<x.Length-1;i++)
            {
                min = min > x[i + 1] ? x[i + 1] :min;
            }
            return min;
        }

        static double[] SUM(double []x,double[] y)
        {
            double[] z = new double[x.Length];
            for(int i = 0; i < z.Length; i++)
            {
                z[i] = x[i] + y[i];
            }
            return z;
        }
        static void Main(string[] args)
        {
            double[] a = { 1, 4, 6, 8, 9 };
            double[] b = { 2, 3, 5, 7, 10};
            double[] c = { 1, 3, 5, 7, 9 };
            double t = MIN(a) < MAX(b) ? MAX(b) / MAX(a) + MAX(c) / MAX(SUM(a, c)) : MAX(SUM(b, c)) + MAX(c);
            Console.WriteLine(t);
            Console.ReadKey(true);
        }
    }
}

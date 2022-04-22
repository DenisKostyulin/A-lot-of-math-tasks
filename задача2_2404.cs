using System;

namespace ConsoleApp1
{
    class Program
    {
        static double VecMulti(double[]x,double[]y)
        {
            int length = x.Length;
            double res=0;
            for(int i = 0; i < length; i++)
            {
                res +=x[i]*y[i];
            }
            return res;
        }
        static void MaxMin(ref double[] x, ref double[]y,ref double[]z)
        {
            double minA = x[0], minB = y[0], minC = z[0];
            int length = x.Length;
            for(int i = 1; i < length-1; i++)
            {
                minA = minA < x[i] ? minA : x[i];
                minB = minB < y[i] ? minB : y[i];
                minC = minC < z[i] ? minC : z[i];
            }
            if (minB > minA && minB > minC)
            {
                double[] help = new double[length];
                for(int i = 0; i < length; i++)
                {
                    help[i] = y[i];
                    y[i] = x[i];
                    x[i] = help[i];
                }
            }
            else if(minC > minB && minC > minA)
            {
                double[] help = new double[length];
                for (int i = 0; i < length; i++)
                {
                    help[i] = z[i];
                    z[i] = x[i];
                    x[i] = help[i];
                }
            }
        }
        static void Main(string[] args)
        {
            int n = 3;
            double res;
            double[] a = new double[n];
            double[] b = new double[n];
            double[] c = new double[n];
            for(int i = 0; i < n; i++)
            {
                a[i] = 3;
                b[i] = 2;
                c[i] = 1;
            }
            MaxMin(ref a,ref b,ref c);
            res=VecMulti(a, a) - VecMulti(b, c);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}

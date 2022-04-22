using System;
namespace ConsoleApp39
{
    class Program
    {
        delegate double[] fun(double[] x);
        static double[] xx(double[] x)
        {
            double[] a = new double[x.Length];
            for(int i = 0; i < x.Length; i++)
            {
                a[i] = 1 - x[i] * x[i];
            }
            return a;
        }
        static double[] fsin(double[] x)
        {
            double []a = new double [x.Length];
            for(int i = 0; i < x.Length; i++)
            {
                a[i] = Math.Sin(x[i]) + 2;
            }
            return a;
        }
        static double Multi(double []x, fun f)
        {
            double[] a = f(x);
            double p = 1;
            for(int i = 0; i < a.Length; i++)
            {
                p *= a[i];
            }
            return p;
        }
        static void Main(string[] args)
        {
            double[] x = { 0,0,0};
            double[] y = { 2,2,2 };
            double[] z = {3,3,3};
            double res = Multi(y, xx) > .5 ? Multi(x, fsin) : Multi(z, xx);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}

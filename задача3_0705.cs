using System;
using System.Collections;

namespace ConsoleApp2
{
    delegate double fun(double x);
    class FuncClass
    {
        public static double intersections(fun f, double eps,double a,double b)
        {
            double c;
            do
            {
                c = (a + b) / 2;
                if (Math.Abs(f(c)) < eps) break;
                if ((f(a) * f(c)) > 0)
                    a = c;
                else
                    b = c;
            } while (Math.Abs(f(c)) >= eps);
            return c;
        }
    }
    class Program
    {
        static double funcX(double x)
        {
            return (1 / (1 + x * x)) - x;
        }
        static double funcEXP(double x)
        {
            return 3 * Math.Exp(x) + x;
        }
        static double funcLN(double x)
        {
            return x * Math.Log(1 + x) - .5;
        }
        static void Main(string[] args)
        {
            double eps = 1E-6;
            ArrayList al = new ArrayList();
            al.Add(FuncClass.intersections(funcX,eps,-2,1));
            al.Add(FuncClass.intersections(funcEXP, eps, -2, 1));
            al.Add(FuncClass.intersections(funcLN,eps,-0.9,0));
            al.Add(FuncClass.intersections(funcLN, eps, 0, 1));
            al.Sort();
            foreach (double l in al)
            {
                Console.WriteLine(l);
            }
            Console.ReadLine();
        }
    }
}

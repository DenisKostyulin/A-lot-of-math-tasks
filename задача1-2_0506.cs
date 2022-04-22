using System;
using System.Numerics;

namespace ConsoleApp54
{
    class Program
    {
        static Complex EXP(Complex z, double eps, out int p1)
        {
            p1 = 0;
            Complex n = 2;
            Complex y1 = 1,y2;
            Complex d = z;
            do
            {
                p1++;
                y2 = y1;
                y1 += d;
                d *= z / n;
                n += 1;
            } 
            while (Complex.Abs(y2-y1)>eps);
            return y1;
        }
        static Complex SIN(Complex z, double eps, out int p2)
        {
            p2 = 0;
            Complex n = 3;
            Complex y1 = z, y2;
            Complex d = -z*z*z/6;
            do
            {
                p2++;
                y2 = y1;
                y1 += d;
                d *= -z*z / (n+1)/(n+2);
                n += 2;
            }
            while (Complex.Abs(y2 - y1) > eps);
            return y1;
        }
        static Complex LOG(Complex z, double eps, out int p3)
        {
            p3 = 0;
            Complex n = 2;
            Complex y1 = z, y2;
            Complex d = -z*z;
            do
            {
                p3++;
                y2 = y1;
                y1 += d/n;
                d *= -z;
                n += 1;
            }
            while (Complex.Abs(y2 - y1) > eps);
            return y1;
        }
        static void Main(string[] args)
        {
            int p1,p2,p3;
            double eps = 1E-9;
            Complex z = new Complex(.5,.5);

            Console.Write("Exp(мой метод):  ");
            Console.WriteLine(EXP(z,eps,out p1));
            Console.WriteLine("Число иттерация:  "+p1);
            Console.Write("Exp(метод из библиотеки):  ");
            Console.WriteLine(Complex.Exp(z));

            Console.WriteLine();

            Console.Write("Sin(мой метод):  ");
            Console.WriteLine(SIN(z, eps,out p2));
            Console.WriteLine("Число иттерация:  " + p2);
            Console.Write("Sin(метод из библиотеки):  ");
            Console.WriteLine(Complex.Sin(z));

            Console.WriteLine();

            Console.Write("Log(мой метод):  ");
            Console.WriteLine(LOG(z, eps, out p3));
            Console.WriteLine("Число иттерация:  " + p3);
            Console.Write("Log(метод из библиотеки):  ");
            Console.WriteLine(Complex.Log(1+z));

            Console.ReadLine();
        }
    }
}

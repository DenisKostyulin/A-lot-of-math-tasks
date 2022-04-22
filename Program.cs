using System;

namespace ряд_тейлора_логарифм
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите х");
            double x = double.Parse(Console.ReadLine());
            double n = 2;
            double y1 = 1,y2;
            double eps = 1E-8;
            double d = x*x/n;
            do
            {
                y2 = y1;
                y1 += d;
                d *= x * x / (n+1) / (n + 2);
                n += 2;
            }
            while (Math.Abs(y1)-Math.Abs(y2) > eps);
            Console.WriteLine($"ряд тейлора {y1}");
            double y3 = (Math.Exp(x) + Math.Exp(-x)) / 2; ;
            Console.WriteLine($"компьютер {y3}");
            Console.ReadKey();
        }
    }
}

using System;

namespace ConsoleApp50
{
    class Program
    {
        static double Func(double[]ABC,double XYZ)
        {
            double res = 0;
            double length = ABC.Length;
            for(int i = 0; i < length; i++)
            {
                res += ABC[i] * Math.Pow(XYZ,length-i-1);
            }
            return res;
        }
        static void Main(string[] args)
        {
            int n = 31;
            double[] a = new double[n];
            double[] b= new double[n];
            double[] c = new double[n];
            Random rnd = new Random();
            for(int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(10);
                b[i] = rnd.Next(10);
                c[i] = rnd.Next(10);
            }
            Console.WriteLine("Массив коэф-ов А:  ");
            foreach (double l in a)
            {
                Console.Write(l+" ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Массив коэф-ов B:  ");
            foreach (double l in b)
            {
                Console.Write(l + " ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Массив коэф-ов C:  ");
            foreach (double l in c)
            {
                Console.Write(l + " ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Введите X:");
            double x = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Y:");
            double y = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Z:");
            double z = Double.Parse(Console.ReadLine());
            Console.WriteLine("Результат функции: "+(Func(a, x) * Func(a, x) - Func(b, y)) / Func(c, x + z));
            Console.ReadLine();
        }
    }
}

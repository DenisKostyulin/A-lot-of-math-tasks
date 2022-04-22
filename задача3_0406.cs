using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] s = new double[1000];
            for (int i = 0; i < 1000; i++)
                s[i] = i;

            List<int> fib = new List<int>();
            int k = 2;
            fib.Add(0);
            fib.Add(1);
            do
            {
                fib.Add(fib[k - 1] + fib[k - 2]);
                k++;
            }
            while (fib[k-1] < 1000);

            for (int i =0; i < k-1; i++)
            {
                Console.WriteLine(s[fib[i]]);
            }
            Console.ReadKey(true);
        }
    }
}

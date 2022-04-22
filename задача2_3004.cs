using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static double Max(double[,]A,int n,int k,int x)
        {
            while(!(n < k && x > n && x > k))
            {
                Console.WriteLine("Enter new parametrs");
                n = int.Parse(Console.ReadLine());
                k = int.Parse(Console.ReadLine());
            }
                double max = A[0, n];
                for (int i = 0; i < x; i++)
                {
                for (int j = n; j <= k; j++)
                {
                    if (max < A[i, j])
                    {
                        max = A[i, j];
                    }
                }
                }
                for (int i = n ; i <= k; i++)
                {
                for (int j = 0; j <= n; j++)
                {
                    if (max < A[i, j])
                    {
                        max = A[i, j];
                    }
                }
                }
                for (int i = n ; i <= k; i++)
                {
                    for (int j = k ; j < x; j++)
                    {
                    if (max < A[i, j])
                    {
                        max = A[i, j];
                    }
                }
                }
                return max;
            
        }
        static void Main(string[] args)
        {
            int x = 6, n=2, k=4;
            int zapolnenie = 1;
            double[,] A = new double[x,x];

            for (int i = 0; i < x; i++)
                for (int j = 0; j < x; j++)
                    A[i, j] = zapolnenie++;

            Console.WriteLine(Max(A,n,k,x));
            Console.ReadLine();
        }
    }
}

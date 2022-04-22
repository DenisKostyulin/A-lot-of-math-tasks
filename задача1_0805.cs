using System;

namespace ConsoleApp44
{
    class Massive
    {
        public static double MaxMulti(double[,]A,int n, int m)
        {
            double[] max = new double[n];
            int i, j;
            double sum = 0;
            for(i = 0; i < n; i++)
            {
                max[i] = A[i, 0];
                for (j=1;j<m;j++)
                {
                    if (max[i] < A[i, j]) max[i] = A[i, j];
                }
            }
            for (i = 0 ; i < n; i++)
            {
                sum += max[i] * max[n-1-i];
            }
            return sum;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = 3, m = 4,counter=1;
            double[,] A = new double[n,m];
            for(int i=0;i<n;i++)
                for(int j = 0; j < m; j++)
                {
                    A[i, j] = counter;
                    counter++;
                }
            Console.WriteLine(Massive.MaxMulti(A,n,m));
            Console.ReadLine();
        }
    }
}

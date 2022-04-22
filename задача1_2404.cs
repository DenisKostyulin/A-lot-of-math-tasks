using System;
namespace ConsoleApp41
{
    class Program
    {
        static void Stepen(int n, int z, double[,] A, out double[,] D)
        {
            D = new double[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    D[i, j] = A[i, j];
            double[,] MAS =z>1?new double[n, n]:null;
            for (int p=z;p>1;p--) 
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        MAS[i, j] = 0;
                        for (int k = 0; k < n; k++)
                            MAS[i, j] += D[i, k] * A[k, j];
                    }
                }
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        D[i, j] = MAS[i, j];
            }
        }
        static void Main(string[] args)
        {
            int n =3,z=3;
            double[,] A = { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
            double[,] D;
            Stepen(n,z,A,out D);
            for (int i=0;i<n;i++)
            {
                for (int j=0;j<n;j++)
                {
                    Console.Write(D[i,j]+"\t");
                }
                Console.WriteLine("\n\n");
            }
            Console.ReadLine();
        }
    }
}

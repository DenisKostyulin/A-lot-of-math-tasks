using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    class Program
    {
        static double[,] Stepen(int n, int z, double[,] A)
        {
            double[,] MAS =new double[n, n];
            double[,] S = new double[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    S[i, j] = A[i, j];
            for (int p = z; p > 1; p--)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        MAS[i, j] = 0;
                        for (int k = 0; k < n; k++)
                            MAS[i, j] += S[i, k] * A[k, j];
                    }
                }
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        S[i, j] = MAS[i, j];
            }
            return MAS;
        }
        static double[,] Multi(double[,] A, double[,] B, int n)
        {
            double[,] MAS =new double[n, n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        MAS[i, j] = 0;
                        for (int k = 0; k < n; k++)
                            MAS[i, j] += A[i, k] * B[k, j];
                    }
                }
            return MAS;
        }
        static void Print(double[,] A,int n)
        {
            for(int i=0;i<n;i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(A[i,j]+"\t");
                }
                Console.WriteLine("\n");
            }
        }
        static void Main(string[] args)
        {
            int n = 3;
            int z = 3;
            double[,] A = new double[n,n];
            double[,] B = new double[n,n];
            double[,] C = new double[n,n];
            for(int i=0;i<n;i++)
                for(int j=0;j<n;j++)
                {
                    A[i,j] = 1;
                    B[i,j] = 1;
                    C[i,j] = 1;
                }
            Print(Stepen(n, z,(Multi(A,Multi(B, C, n), n))), n);
            Console.ReadLine();
        }
    }
}

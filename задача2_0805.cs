using System;

namespace ConsoleApp1
{
    class Massive
    {
        public static void CONSTR(double[,]A, double[,] B, double[,] C,double[,]N,out double[,] D,int t1, int t21, int t22)
        {
            D = new double[t21,t22];
            int i, j;
            for (i=0;i<t1;i++)
            {
                for (j=0;j<t1;j++)
                {
                    D[i, j] =A[i,j];
                    D[i,j+t1]=B[i,j];
                    D[i,j+2*t1]=C[i,j];
                }
            }
            for (i = 0; i < t1; i++)
            {
                for (j = 0; j < t1; j++)
                {
                    D[i+t1, j] = B[i, j];
                    D[i+t1, j + t1 ] = N[i, j];
                    D[i+t1, j + 2 * t1] = A[i, j];
                }
            }
        }
        public static void Print(double[,]D,int t21,int t22)
        {
            for (int i = 0; i < t21; i++)
            {
                for (int j = 0; j < t22; j++)
                {
                    Console.Write(D[i,j]+" ");
                }
                Console.WriteLine("\n");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        { int t1 = 10, t21 = 20, t22 = 30;
            double[,] A = new double[t1, t1];
            double[,] B = new double[t1, t1];
            double[,] C = new double[t1, t1];
            double[,] N = new double[t1, t1];
            double[,] D;
            for(int i=0;i<t1;i++)
                for(int j = 0; j < t1; j++)
                {
                    A[i, j] =1;
                    B[i, j] =2;
                    C[i, j] =3;
                    N[i, j] =0;
                }
            Massive.CONSTR(A, B, C, N, out D, t1, t21, t22);
            Massive.Print(D,t21,t22);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void MaxSwap(double[,]A,double [,]B,int n,int m)
        {
           double maxA=A[0,0],maxB=B[0,0];
            int maxiA = 0,maxjA = 0,maxiB = 0,maxjB = 0;
          for(int i=0;i<n;i++)
                for(int j = 0; j < m; j++)
                {
                    if (maxA < A[i, j])
                    {
                        maxA = A[i, j];
                        maxiA = i;
                        maxjA = j;

                    }
                    if (maxB < B[i, j])
                    {
                        maxB = B[i, j];
                        maxiB = i;
                        maxjB = j;
                    }
                }
            double swap = A[maxiA, maxjA];
            A[maxiA, maxjA] = B[maxiB, maxjB];
            B[maxiB, maxjB] = swap;
        }
        static void Print(double[,] A,int n,int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++) 
                {
                    Console.Write(A[i,j]+"\t");
                }
                Console.WriteLine("\n");
            }
        }
        static void Main(string[] args)
        {
            int n = 3,m = 4,zap1=1,zap2=5;
            double[,] A = new double[n, m];
            double[,] B = new double[n, m];
            for(int i=0;i<n;i++)
                for(int j = 0; j < m; j++)
                {
                    A[i, j] = zap1++;
                    B[i, j] = zap2++;
                }
            Print(A, n, m);
            Console.WriteLine("\n");
            Print(B, n, m);
            Console.WriteLine("\n");
            MaxSwap(A, B, n, m);
            Print(A,n,m);
            Console.WriteLine("\n");
            Print(B,n,m);
            Console.ReadLine();
        }
    }
}

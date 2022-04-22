using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static double[,] SumMas(double [,]x,double[,]y)
        {
            double[,] a = new double[10,20];
            for(int i=0;i<10;i++)
                for(int j = 0; j < 20; j++)
                {
                    a[i, j] = x[i, j] + y[i, j];
                }
            return a;
        }
        static double Max(double[,]x,int i)
        {
            double max = x[i, 0];
            for (int j = 1; j < 19; j++)
            {
                max = max < x[i, j] ? x[i, j] : max;
            }
            return max;
        }
        static double D(double[,] x)
        {
            double d = 0;
            for (int i=0;i<10;i++)
            {
                d +=Max(x,i);
            }
            return d;
        }
        static void Main(string[] args)
        {
            double[,] A = new double[10, 20];
            double[,] B = new double[10, 20];
            double[,] C = new double[10, 20];
            for(int i=0;i<10;i++)
                for(int j=0;j<20;j++)
                {
                    A[i, j] = 1;
                    B[i, j] = 1;
                    C[i, j] = 1;
                }
            for(int i=0;i<10;i++)
            {
                A[i, 7] = 2;
                B[i, 7] = 2;
                C[i, 7] = 2;
            }


            double res;
            res = (D(A) + D(B) + D(C)) / D(SumMas(SumMas(A,B),C));
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}

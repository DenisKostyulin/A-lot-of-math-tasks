using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    class Matrix 
    {
        public static void Transpose(ref double[,]x,int n)
        {
            double extra;
            for(int i = 0; i < n-1; i++)
                for(int j = i+1; j < n; j++)
                {
                    extra = x[i, j];
                    x[i, j] = x[j, i];
                    x[j, i] = extra;
                }
        }
        public static double[,] Multi(double[,] x, double[,] y, int n)
        {
            double[,] z = new double[n,n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    z[i, j] = 0;
                    for (int k = 0; k < n; k++)
                        z[i, j] += x[i, k] * y[k, j];
                }
            return z;
        }
        public static double Det(double[,] x, int n)
        {
            if (n == 2) return x[0, 0] * x[1, 1] - x[1, 0] * x[0, 1];
            double det = 0;
            for (int j = 0; j < n; j++)
            {
                det += Math.Pow(-1, j+2) * x[0, j] * Det(CutOff(x, n,0, j), n-1);
            }
            return det;
        }
        static double[,] CutOff(double[,] x, int n1,int i1, int j1)
        {
            int i, j;
            double[,] x1 = new double[n1-1, n1-1];
            for (i=0;i<i1;i++)
                for (j=0;j<j1;j++)
                    x1[i, j] = x[i, j];

            for (i = 0; i <i1; i++)
                for (j = j1+1; j <n1; j++)
                    x1[i, j-1] = x[i, j];

            for (i = i1+1; i <n1; i++)
                for (j = 0; j <j1; j++)
                    x1[i-1, j] = x[i, j];

            for (i = i1+1; i <n1; i++)
                for (j = j1+1; j <n1; j++)
                    x1[i-1, j-1] = x[i, j];
            return x1;
        }
        static double Minor(double [,]x,int n,int i1,int j1)
        {
            return Math.Pow(-1, j1 + i1)* Det(CutOff(x, n, i1, j1), n - 1);
        }
        public static void Back(ref double[,]x,int n)
        {
            double det=Det(x, n);
            double[,] x1 = new double[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    x1[i, j] = Minor(x,n,i,j);
            Transpose(ref x1,n);
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++) 
                { 
                    x1[i, j] = x1[i, j] / det;
                    x[i, j] = x1[i, j];
                }
        }

        public static void Print(double[,] A, int n)
        {
            Console.WriteLine("--------------------------------------------------------------------------------");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (Math.Abs(A[i, j]) < 1E-6) Console.Write(0 + "\t");
                    else Console.Write(A[i, j] + "\t");
                }
                Console.WriteLine("\n\n");
            }
            Console.WriteLine("--------------------------------------------------------------------------------");
        }
    }

    class Program
    {
        static void Main()
        {
            int n = 5;
            double[,] A = { { 3, 1, -1, 2, 1 }, { -2, 3, 1, 4, 3 }, { 1, 4, 2, 3, 1 }, { 5, -2, -3, 5, -1 }, { -1, 1, 2, 3, 2 } };
            //#region Первая задача

            //Matrix.Print(A,n);
            //double[,] B = new double[n,n];
            //for (int i = 0; i < n; i++)
            //    for (int j=0;j<n;j++)
            //    {
            //        B[i, j] = A[i, j];
            //    }
            //Matrix.Transpose(ref B,n);
            //Matrix.Print(Matrix.Multi(A,B,n),n);

            //#endregion
            #region Вторая задача

            Matrix.Print(A, n);
            double[,] C = new double[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    C[i, j] = A[i, j];
                }
            Matrix.Back(ref C,n);
            Matrix.Print(C,n);
            Matrix.Print(Matrix.Multi(A,C,n),n);

            #endregion
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Matrix
    {
        public static double[,] Pow(double[,] X,int size)
        {
            if (size > 1)
            {
                double[,] MAS = new double[size, size];
                for (int p = size; p > 1; p--)
                {
                    for (int i = 0; i < size; i++)
                    {
                        for (int j = 0; j < size; j++)
                        {
                            MAS[i, j] = 0;
                            for (int k = 0; k < size; k++)
                                MAS[i, j] += X[i, k] * X[k, j];
                        }
                    }
                }
                return MAS;
            }
            else
                return X;
        }
        public static double[,] Compare(double[,]X,double[,]Y,int size)
        {
            return Spur(X, size) > Spur(Y, size) ? Y : X;
        }
        public static double Spur(double[,]X,int size)
        {
            double matrixX = 0;
            for(int i = 0; i < size; i++)
            {
                matrixX += X[i,i];
            }
            return matrixX;
        }
        public static void Print(double[,]A,int size)
        {
            for (int i=0;i<size;i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(A[i,j]+"  ");
                }
                Console.WriteLine("\n");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int size = 10;
            double[,] A = new double[size, size];
            double[,] B = new double[size,size];

            for (int i=0;i<size;i++)
                for (int j=0;j<size;j++)
                    A[i, j] = 1;

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    B[i, j] = 2;

            Matrix.Print(Matrix.Pow(Matrix.Compare(A,B,size),size),size);
            Console.ReadLine();
        }
    }
}

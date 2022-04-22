using System;
namespace ConsoleApp2
{
    class Program
    {
        static double VecMulti(double []x,double[]y)
        {
            double length = x.Length,res=0;
            for(int i = 0; i < length; i++)
            {
                res+=x[i] * y[i];
            }
            return res;
        }
        static double[] MatVec(double[,] x, double[] y)
        {
            int length = y.Length;
            double[] mas = new double[length];
            for (int i = 0; i < length; i++)
            {
                mas[i] = 0;
                for (int j = 0; j < length; j++)
                {
                    mas[i] += x[i, j] * y[j];
                }
            }
            return mas;
        }
        static void Main(string[] args)
        {
            double[,] A = new double[6, 6];
            double[,] B = new double[6, 6];
            double[,] C = new double[6, 6];
            double[] x = new double[6];
            double[] y = new double[6];
            for (int i = 0; i < 6; i++)
            {
                x[i] = 1;
                y[i] = 1;
                for (int j = 0; j < 6; j++)
                {
                    A[i, j] = 1;
                    B[i, j] = 1;
                    C[i, j] = 1;
                }
            }
            double res = VecMulti(MatVec(A, x), MatVec(B, y)) + VecMulti(MatVec(C, x), y) / VecMulti(MatVec(B, y), x);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}

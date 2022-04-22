using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static double Det(double[,] x, int n)
        {
            int i, j, k;
            double d = 1, s = 1, bufer;
            if (x[0, 0] == 0)
            {
                for (i = 1; i < n; i++)
                    if (x[i, 0] != 0)
                    {
                        for (j = 0; j < n; j++)
                        {
                            bufer = x[0, j];
                            x[0, j] = x[i, j];
                            x[i, j] = bufer;
                            s = -s;
                        }
                        break;
                    }
                Console.WriteLine($"Замена строк:");
                Console.WriteLine();
            }
            double b;
            for (k = 0; k < n - 1; k++)
                for (i = 1 + k; i < n; i++)
                {
                    b = x[i, k];
                    if (x[i, k] != 0)
                    {
                        for (j = k; j < n; j++)
                            x[i, j] = x[i, j] - (x[k, j] * b) / x[k, k];
                    }
                }
            for (i = 0; i < n; i++)
                d *= x[i, i];
            return d * s;
        }

        static double Minor(double[,] x, int l, int ix, int jx, int n, int p)
        {
            int i, j, k, di, dj, k2;
            double r = 0;
            double[,] y = new double[l + 1, l + 1];
            for (k = 0; k < p - l; k++)
                for (k2 = 0; k2 < (n - l); k2++)
                    for (i = 0; i < l + 1; i++)
                        for (j = 0; j < l + 1; j++)
                        {
                            if (i >= 1) di = k;
                            else di = 0;
                            if (j >= 1) dj = k2;
                            else dj = 0;
                            y[i, j] = x[ix + i + di, jx + j + dj];
                        }
            if (Det(y, l + 1) != 0)
            {
                return 1;
            }
            return r;
        }
        static double Rang(double[,] x, int n, int p)
        {
            int i, j, ix = 0, jx = 0, k, l;
            int count = 0;
            double r = 0;
            k = Math.Min(n, p);
            for (i = 0; i < n; i++)
                for (j = 0; j < p; j++)
                {
                    count++;
                    if (x[i, j] != 0)
                    {
                        ix = i;
                        jx = j;
                        goto lbl;
                    }
                }
            lbl:
            if (count == n * p)
            {
                return 0;
            }
            for (l = 1; l <= k; l++)
            {
                r = l;
                if (r == k) return r;

                if (Minor(x, l, ix, jx, n, p) == 0) return r;
            }
            return r;
        }
        static string Dependence(double [,]A,int n,int p)
        {
            double r = 0;
            int count = 1;
            if (p > n) return "линейно зависима";
            for (int i = 0; i < p; i++)
            {
                r = A[i,0];
                for (int j = 1; j < n; j++)
                {
                    if (r == A[i, j]) count++;
                }
                if (count == n) return "линейно зависима";
                count = 1;
            }
            for (int i = 0; i < p - 1; i++)
                for (int j = i + 1; j < p; j++)
                {
                    r = A[i, 0] / A[j, 0];
                    for (int k = 1; k < n; k++)
                    {
                        if (A[i, k] / A[j, k] == r) count++;
                    }
                    if (count == n) return "линейно зависима";
                    count=1;
                }
            r = Rang(A,n,p);
            if (r < p) return "линейно зависима";
            else return "линейно независима";
        }
        static void Main(string[] args)
        {
            int n = 5, p = 4;
            double[,] A = new double[,]
            {
                {1,2,-1,-2,0 },
                {2 ,3,0,-2,1},
                {1,2,1,4,2 },
                { 1,3,-1,0,-1}
            };
            Console.WriteLine("Матрица A:\n");
            for(int i = 0; i < p; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write(A[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Матрица А "+Dependence(A,n,p));
            Console.ReadLine();
        }
    }
}

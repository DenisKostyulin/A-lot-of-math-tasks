using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class задача3_1704
    {
        static double[,] Multi(double[,] x, double[,] y,int rowx, int rowy, int columnx, int columny)
        { double[,] z = new double[rowx,columny];
            for (int i = 0; i < rowx; i++)
                for (int j = 0; j < columny; j++)
                {
                    z[i, j] = 0;
                    for (int k = 0; k < columnx; k++)
                        z[i, j] += x[i, k] * y[k, j];
                }
            return z;
        }
        static void PrintMatrix(double [,] x,int row,int column)
        {
            for(int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                    Console.Write(x[i,j]+" ");
                Console.WriteLine("\n");
            }
        }
        static void Main(string[] args)
        {
            int rowx = 3, columnx = 3;
            int rowy = 3, columny = 2;
            double[,] x = new double[rowx, columnx];
            double[,] y = new double[rowy, columny];
            for (int i = 0; i<rowx; i++)
                for (int j = 0; j < columnx; j++)
                    x[i, j] = j;
            for (int i = 0; i < rowy; i++)
                for (int j = 0; j < columny; j++)
                    y[i, j] = j;
            PrintMatrix(Multi(x,y,rowx,rowy,columnx,columny),rowx,columny);
            Console.ReadLine();
        }
    }
}

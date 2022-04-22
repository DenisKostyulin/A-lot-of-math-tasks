using System;

namespace ConsoleApp2
{
    class Matrix
    {
        public static double Det(double[,] A, int n)
        {
            if (n == 2) return A[0, 0] * A[1, 1] - A[1, 0] * A[0, 1];//сначала проверяю порядок матрицы
            double det = 0;//для каждой матрицы в ходе рекурсии определяю детерминант det=0
            for (int j = 0; j < n; j++)//иттерируюсь по всем элементам первой строки 
            {
                det += Math.Pow(-1, j + 2) * A[0, j] * Det(CutOff(A, n, j), n - 1);//рекурсия, продолжается до тех пор пока не урежет исходную матрицу до минимального порядка 2, после чего пойдет назад
            }
            return det;
        }
        public static double[,] CutOff(double[,] A, int n1, int j1)//Метод "вырезает" матрицу исходя из его порядка- n1 и индекса текущего элемента -j1
        {
            double[,] A1 = new double[n1, n1];
            for (int i = 1; i < n1; i++)
            {
                for (int j = 0; j < j1; j++)
                {
                    A1[i - 1, j] = A[i, j];
                }
            }
            for (int i = 1; i < n1; i++)
            {
                for (int j = j1 + 1; j < n1; j++)
                {
                    A1[i - 1, j - 1] = A[i, j];
                }
            }
            return A1;
        }
        public static void Print(double[,] A, int n)//печать квадратной матрицы в консоль
        {
            Console.WriteLine("--------------------------------------------------------------------------------");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(A[i, j] + "\t");
                }
                Console.WriteLine("\n\n");
            }
            Console.WriteLine("--------------------------------------------------------------------------------");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            double[,] A = { {3,1,-1,2,1 },{-2,3,1,4,3},{1,4,2,3,1 },{5,-2,-3,5,-1 },{-1,1,2,3,2 } };//привел в пример матрицу из задания на 14.05
            Matrix.Print(A,n);//печатаю матрицу
            Console.Write(Matrix.Det(A,n));//ответ: 446
            Console.ReadLine();
        }
    }
}

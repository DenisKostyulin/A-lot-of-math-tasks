using System;

namespace ConsoleApp1
{
    class Matrix 
    {
        public static double Det1(double[,] A, int n)//метод считает определитель методом Гаусса
        {
            int count = 0;//переменная хранит количество перемен строк 
            double det = 1;// детерминант 
            for (int i = 0, j = 0; i < n && j < n; i++, j++)// запускаю иттерацию по главной диагонали
            {
                if (A[i, j] == 0)//если встречаю на своем пути 0, то произвожу замену данной строки с другой, в которой в этом столбце нуля нет
                {
                    if (i == n - 1) continue;//ставлю "стопарь" на последний элемент в главной диагонали, считая его ненулевым
                    for (int k = i + 1; k < n; k++)//иттерируюсь по строке после текущей вдоль текущего столбца в поисках ненулевого элемента
                    {
                        if (A[k, j] != 0)
                        {
                            Swap(ref A, n, i, k);//произвожу замену методом swap,использую ref, чтобы "видеть" изменения с этом методе
                            count++;//увеличиваю кол-во перемен строк на единичку
                            break;//как только нашел ненулевой элемент и совершил замену, выхожу с цикла и начинаю идти дальше
                        }
                    }
                }
                for (int k = i + 1; k < n; k++)
                {
                    double a = -(double)(A[k, j]) / (double)A[i, j];//иттерационно с помощью формулы зануляю нижний треугольник в матрице
                    for (int q = j; q < n; q++)
                    {
                        A[k, q] += a * A[i, q];
                    }
                }
            }
            for (int i = 0, j = 0; i < n & j < n; i++, j++)
            {
                det *= A[i, j]; //считаю детерминант
            }
            det *= Math.Pow(-1, count);//умножаю на -1 в степени кол-ва перемен строк
            return det;
        }
        static double[,] Swap(ref double[,] A, int n, int s1, int s2)
        {
            double help;
            for (int i = 0; i < n; i++)//замена двух строк 
            {
                help = A[s1, i];
                A[s1, i] = A[s2, i];
                A[s2, i] = help;
            }
            return A;
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
            double[,] A = { { 3, 1, -1, 2, 1 }, { -2, 3, 1, 4, 3 }, { 1, 4, 2, 3, 1 }, { 5, -2, -3, 5, -1 }, { -1, 1, 2, 3, 2 } };
            Matrix.Print(A, n);//печатаю матрицу
            Console.Write(Matrix.Det1(A, n));//ответ: 446
            Console.ReadLine();
        }
    }
}

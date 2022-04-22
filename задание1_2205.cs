using System;
using System.Collections.Generic;

namespace ConsoleApp48
{
    class Matrix
    {
        public static void Kramer(double[,]x,out double[]solveKramer ,int n)// поиск корней СЛУ методом Крамера
        {
            double[,] xarr = new double[n, n + 1];//создаю новый массив и переношу туда все элементы из предыдущего , чтобы не портить его
            for (int i = 0; i < n; i++)
                for (int j = 0; j <= n; j++)
                    xarr[i, j] = x[i, j];

            solveKramer = new double[n];//инициализирую массив для корней

            double[] b = new double[n];//создаю массив для своободных членов массива 
            for (int i = 0; i < n; i++)
                b[i] = x[i, n];

            Back(xarr, n);//нахожу обратную матрицу

            double[] arr;//объявляю массив для передачи по out  в метод для умножения обратной матрицы на столбец свободных членов
            Multi(xarr, b,out arr, n);//перемножаю обратную матрицу на столбец свободных членов

            for (int i = 0; i < n; i++)
            {
                solveKramer[i]=arr[i];//иттерационно переношу решения СЛУ в массив решений
            }
        }
        public static void Transpose(double[,] x, int n)//Транспонирование матрицы
        {
            double extra;//вспомогательная переменная для транспонирования
            for (int i = 0; i < n-1; i++)//транспонирование
                for (int j = i + 1; j < n; j++)
                {
                    extra = x[i, j];
                    x[i, j] = x[j, i];
                    x[j, i] = extra;
                }
        }
        static void Multi(double[,]x,double[]y,out double[]arr,int n)//перегруженный метод перемножения квадратной матрицы на матрицу-столбец
        {
            arr = new double[n];//в массив arr возвращаю результат умножения
            for (int i = 0; i < n; i++)
                    for (int k = 0; k < n; k++)
                        arr[i] += x[i, k] * y[k];
        }
        public static double[,] Multi(double[,] x, double[,] y, int n)//перегруженный метод перемножения квадратных матриц
        {
            double[,] z = new double[n, n];//матрица z , в которую будет возвращен результат умножения
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    for (int k = 0; k < n; k++)
                        z[i, j] += x[i, k] * y[k, j];
            return z;
        }
        public static double Det(double[,] x, int n)//метод рекурсионного поиска определителя
        {
            if (n == 2) return x[0, 0] * x[1, 1] - x[1, 0] * x[0, 1];
            double det = 0;
            for (int j = 0; j < n; j++)
            {
                det += Math.Pow(-1, j + 2) * x[0, j] * Det(CutOff(x, n, 0, j), n - 1);
            }
            return det;
        }
        static double[,] CutOff(double[,] x, int n1, int i1, int j1)// специализированный метод для другого метода Det(), который из исходной матрицы вырезает другую исход из текущего элемента, вырезая соответствующий стобец и строку
        {
            int i, j;
            double[,] x1 = new double[n1 - 1, n1 - 1];//матрицу , в которую в итоге будет помещен итог работы метода
            for (i = 0; i < i1; i++)//итерационно переношу все элементы , кроме тех, что имеют тот же индекс текущей строки или(и) текущего стоблца
                for (j = 0; j < j1; j++)
                    x1[i, j] = x[i, j];

            for (i = 0; i < i1; i++)
                for (j = j1 + 1; j < n1; j++)
                    x1[i, j - 1] = x[i, j];

            for (i = i1 + 1; i < n1; i++)
                for (j = 0; j < j1; j++)
                    x1[i - 1, j] = x[i, j];

            for (i = i1 + 1; i < n1; i++)
                for (j = j1 + 1; j < n1; j++)
                    x1[i - 1, j - 1] = x[i, j];
            return x1;
        }
        static double Minor(double[,] x, int n, int i1, int j1)//поиск минора текущего элемента массива x
        {
            return Math.Pow(-1, j1 + i1) * Det(CutOff(x, n, i1, j1), n - 1);
        }
        public static void Back(double[,] x, int n)//поиск обратной матрицы методом миноров
        {
            double det = Det(x, n);//в det присвоил определитель исходной матрицы
            double[,] x1 = new double[n, n];//создаю и заполняю массив минорами исходной матрицы
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    x1[i, j] = Minor(x, n, i, j);
            Transpose(x1, n);//транспонирую ее
            for (int i = 0; i < n; i++)//делю все члены этой матрицы на det, в котором лежит определитель
                for (int j = 0; j < n; j++)
                {
                    x1[i, j] = x1[i, j] / det;
                    x[i, j] = x1[i, j];
                }//в итоге в x уже лежит обратная матрица
        }

        public static void PrintSLE(double[,] x, int n)//метод печати СЛУ в более читабельном виде, с разделением стобца свободных членов
        {
            Console.WriteLine("--------------------------------------------------------------------------------");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n+1; j++)
                {
                    if (Math.Abs(x[i, j]) < 1E-6) Console.Write(0 + "\t");
                    else if (j == n) Console.WriteLine("|||   "+x[i,j]);
                    else Console.Write(x[i, j] + "\t");
                }
                Console.WriteLine("\n\n");
            }
            Console.WriteLine("--------------------------------------------------------------------------------");
        }
        public static void Print(double[]x,int n)//метод для печати одномерной матрицы(в main использую для вывода массива решений СЛУ)
        {
            for (int i = 0; i < n; i++)
                Console.Write(x[i]+"   ");
        }

        public static void Gauss(double[,] x, out double[]solve,int n)//метод для поиска корней СЛУ методом Гаусса
        {
            int i,j,k,q;//индексы(часто их использую)
            double[,] xarr = new double[n, n+1];//создаю новый массив и переношу туда все элементы из предыдущего , чтобы не портить его
            for (i = 0; i < n; i++)
                for (j = 0; j <= n; j++)
                    xarr[i, j] = x[i, j];

            double a,b;//вспомогательные переменные для последующих операций
            solve = new double[n];//инициализирую массив решений

            for (i = 0, j = 0; i < n && j < n; i++, j++)//проверяю члены главной диагонали на нули, если нахожу , то произвожу замену со следующей строкой, если там не ноль
            {
                if (xarr[i, j] == 0)
                {
                    if (i == n - 1) continue;
                    for (k = i + 1; k < n; k++)
                    {
                        if (xarr[k, j] != 0)
                        {
                            Swap(xarr, n, i, k);
                            break;//как только нашел ненулевой элемент в строке, произвожу замену и иду проверять следующие элементы
                        }
                    }
                }
            }
            for (i = 0, j = 0; i < n && j < n; i++, j++)//иттерационно иду в элементам главной диагонали
            {
                a = xarr[i, j];//как только определился с текущим элементом строки, заношу его значение в a , потому что после его порчи я должен буду с ним работать дальше
                for (q = j; q <= n; q++)
                {
                    xarr[i, q] /= a;//делю все члены текущей строки на первый элемент 
                }
                for (k = i + 1; k < n; k++)//иттерируюсь по по строкам, начиная со следующего после текущей строки 
                {
                    b = xarr[k, j];//как только определился с текущей строкой, заношу его значение в b , потому что после его порчи я должен буду с ним работать дальше
                    for (q = j; q <= n; q++)//иттерируюсь от текущего столбца до крайнего, т.к. манипуляции с нулем не будут его менять, избегаю лишних операций
                    {
                        xarr[k, q] += -xarr[i, q]*b;//обнуляю весь столбец после текущего элемента строки
                    }
                }
            }
            for (i = n - 1, j = n - 1; i >= 0 && j >= 0; i--, j--)//делаю то же самое только теперь иттерируюсь по главной диагонали в обратном порядке
            {
                for (k = i - 1; k >= 0; k--)
                {
                    for (q = n; q >= j; q--)
                    {
                        xarr[k, q] += -xarr[i, q] * xarr[k, j];//здесь уже не нужна вспомогательная переменная, т.к. нужное значение я порчу в последний момент, после чего не использую его
                    }
                }
            }
            for (i = 0; i < n; i++)//переношу стобец свободных членов, который получился после всех манипуляция 
                solve[i] = xarr[i,n];
        }
        static void Swap(double[,] x, int n, int s1, int s2)//замена двух строк с индексами строки s1 и s2
        {
            double help;
            for (int i = 0; i <= n; i++)
            {
                help = x[s1, i];
                x[s1, i] = x[s2, i];
                x[s2, i] = help;
            }
        }
    }
    class Program
    {
        static void Main()
        {
            int n = 5;//порядок матрицы
            double[] solveGauss;//объявляю массив решений методом Гаусса
            double[] solveKramer;//объявляю массив решений методом Крамера
            double[,] A = { { 3, 1, -1, 2, 1, 1 }, { -2, 3, 1, 4, 3, 2 }, { 1, 4, 2, 3, 1, 3 }, { 5, -2, -3, 5, -1, 4 }, { -1, 1, 2, 3, 2, 5 } };
            double a = 0, b = 0;//обхявляю вспомогательные переменные для проверки найденных корней

            Matrix.PrintSLE(A,n);//вывожу исходную матрицу

            Matrix.Kramer(A, out solveKramer, n);//нахожу корни СЛУ методом Крамера
            Matrix.Gauss(A, out solveGauss, n);//нахожу корни СЛУ методом Гаусса

            Console.WriteLine("\n---------");
            Console.WriteLine("Гаусс");
            for (int i = 0; i < n; i++)//провожу проверку путем перемножения и сложения найденных корней СЛУ и коэф-ов матрицы(получаю 1,2,3,4,5)
            {
                for (int j = 0; j < n; j++)
                    a += A[i, j] * solveGauss[j];
                Console.Write(a+" ");
                a = 0;
            }
            Console.Write("\nКорни СЛУ (метод Гаусса): ");
            foreach (double l in solveGauss)
            {
                Console.Write(l + "; ");
            }
            Console.WriteLine("\n---------");

            Console.WriteLine("\n---------");
            Console.WriteLine("Крамер");
            for (int i = 0; i < n; i++)//провожу проверку путем перемножения и сложения найденных корней СЛУ и коэф-ов матрицы(получаю 1,2,3,4,5)
            {
                for (int j = 0; j < n; j++)
                    b += A[i, j] * solveKramer[j];
                Console.Write(b+" ");
                b = 0;
            }
            Console.Write("\nКорни СЛУ (метод Крамера): ");
            foreach (double l in solveKramer)
            {
                Console.Write(l+"; ");
            }
            Console.WriteLine("\n---------");

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;

namespace ConsoleApp45
{
    class Matrix 
    {
        public static void SedPoint(double[,]A,int n,int m)//метод определющий седловые точки в данной матрице
        {
            List<int> arr = new List<int>();//создаю list для хранения индексов седловых точек
            int i, j,maxRow, minRow, maxCol, minCol;//объявляю всевозможные индексы, которые будут встречаться в коде далее
            bool bmaxrow, bmaxcol, bminrow, bmincol;//флажки , которые указывают на то, было ли найдено макс. или мин. значение
            for (i = 0; i < n; i++)//иттерируюсь по каждому элементу в матрице
            {
                for (j = 0; j < m; j++)
                {
                    MaxMin(A,n,m,i,j,out maxRow, out minRow, out maxCol, out minCol,out bmaxrow,out bmaxcol,out bminrow,out bmincol);//определяю макс. и мин. значения и их статус
                    if ((bmincol==true)&&(bmaxrow ==true) &&(j==maxRow & i==minCol))//если статус каждого значения true  и индексы элементов совпали, то определенном порядке "i,j" ввожу их в list
                    {
                        arr.Add(i);
                        arr.Add(j);
                    }
                    else if ((bmaxcol==true)&&(bminrow ==true)&&(j == minRow & i == maxCol))
                    {
                        arr.Add(i);
                        arr.Add(j);
                    }
                }
            }
            if (arr.Count>0)//далее если list не пуст, то вывожу на консоль все найденные седловые точки следующим методом
            {
                Console.WriteLine("Были определены следующие седловые точки:\n");
                for (i = 0; i < arr.Count - 1; i+=2)//печатаб индексы с тем учетом, что индекс "i" занимает четные позиции, а "j" нечетные 
                {
                    Console.WriteLine("i: " + arr[i] + "\tj: " + arr[i + 1]);
                }
            }
            else Console.WriteLine("Седловые точки не обнаружены!");
        }
        static void MaxMin(double[,]A,int n,int m,int r,int c,out int maxRow, out int minRow, out int maxCol, out int minCol,out bool bmaxrow, out bool bmaxcol, out bool bminrow, out bool bmincol)//метод поиска максимального и минимального числа в данной строке и в данном столбце
        {
            bmaxrow = bmaxcol = bminrow = bmincol = true;//переменные типа bool хранят подтверждение или опровержение того, что было или не было найдено максимальное значение, изначально стоит true на случай если этот первый элемент и окажется макс. или мин.
            maxRow = minRow = maxCol = minCol =0;//изначально индексы установил в ноль
            for (int i = 1; i < n; i++)//4 цикла определяют эти индексы
            {
                if (A[maxCol, c] < A[i, c])
                {
                    maxCol = i;
                    bmaxcol = true;//если нашел кого-то более удовлетворяющего условию, то true
                }
                else if (A[maxCol, c] == A[i, c]) bmaxcol = false;//если нашел равный себе , то false, значит это уже не максимальный элемент
            }
            for (int i = 1; i < n; i++)//и так далее с каждым
            {
                if (A[minCol, c] > A[i, c])
                {
                    minCol = i;
                    bmincol = true;
                }
                else if(A[minCol, c] == A[i, c]) bmincol = false;
            }
            for (int j = 1; j < m; j++)
            {
                if (A[r, maxRow] < A[r, j])
                {
                    maxRow = j;
                    bmaxrow = true;
                }
                else if(A[r, maxRow] == A[r, j]) bmaxrow = false;
            }
            for (int j = 1; j < m; j++)
            {
                if (A[r, minRow] > A[r, j])
                {
                    minRow = j;
                    bminrow = true;
                }
                else if(A[r, minRow] == A[r, j]) bminrow = false;
            }
        }
        public static void Print(double[,]A,int n,int m)// печатаю матрицу
        {
            Console.WriteLine("--------------------------------------------------------------------------------");
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    Console.Write(A[i,j]+"\t");
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
            int n = 3;
            int m = 4;
            double[,] A = new double[n,m];// для такой маленькой матрицы вероятнее найти седловые точки, можно установить n и m в 10 и 15 соответственно, но разницы нет
            Random rnd = new Random();//заполняю матрицу рандомными числами
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    A[i, j] = rnd.Next(1, 10);
            Matrix.Print(A,n,m);//печатаю матрицу
            Matrix.SedPoint(A,n,m);//ищу и вывожу результат поиска седловых точек
            Console.ReadLine();
        }
    }
}

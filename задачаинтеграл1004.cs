using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    delegate double fun(double x);
    class задачаинтеграл1004
    {
        static double integral(double a, double b, fun f)// метод считает интеграл от функции с заданными пределами методом Симпсона
        {
            double eps = 1E-6;// ошибка усечения
            int n = 10, i;
            double y, t, s = 0, h;
            y = f(a) + f(b);
            h = (b - a) / n;
            for (i = 1; i <= n - 1; i++)
            {
                if (i % 2 != 0)
                    s += 4 * f(a + i * h);
                else
                    s += 2 * f(a + i * h);
            }
            s = h / 3 * (y + s);
            do
            {
                t = s;
                n *= 2; h = (b - a) / n;
                s = 0;
                for (i = 1; i <= n - 1; i++)
                {
                    if (i % 2 != 0)
                        s = s + 4 * f(a + i * h);
                    else
                        s = s + 2 * f(a + i * h);
                }
                s = h / 3 * (y + s);
            } while (Math.Abs(t - s) >= eps); // вычисление интеграла с заданной точностью
            return s; // возвращаем вычисленный интеграл

        }
        static double cos(double x) => Math.Cos(x/2)*(2/x);// метод функции Cos(x/2)*(2/x)
        static double ln(double x) => Math.Log(1+x*x); // метод функции Log(1+x*x)
        static double exp(double x) => Math.Exp(-x * x);// метод функции Exp(-x * x)
        static double intersections(fun f1,fun f2)// метод поиска точек пересечения двух функций , которые передаются в метод
        {
            double eps = 1E-6;// ошибка усечения
            double c,a=0,b=0;

                Console.WriteLine("Enter a");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter b");
                b = double.Parse(Console.ReadLine());
            do // поиск точек пересечния путем половинного деления
            {
                c = (a + b) / 2;
                if (Math.Abs(f2(c)-f1(c)) < eps) break;
                if ((f2(a)-f1(a)) * (f2(c)-f1(c)) > 0)
                    a = c;
                else
                    b = c;
            } while (Math.Abs(f2(c)-f1(c)) >= eps);
            return c; // возвращаем значение, при котором эти две функции пересекаются   
        }
        static void Main(string[] args)
        {
            double INTEGRAL;// переменная, в которую в итоге будет вложен конечный результат
            double r1=intersections(ln,exp); // первая точка пересечения (частный случай)
            double r2= intersections(ln,cos); // вторая точка пересечения (частный случай)
            double r3= intersections(cos,exp); // третья точка пересечения (частный случай)
            double int1 = integral(r1,r2,ln); // вычисление 4-х интегралов в соответствии с найденными пределами(частный случай)
            double int2 = integral(r1,r2,exp);
            double int3 = integral(r2,r3,cos);
            double int4 = integral(r2,r3,exp);
            INTEGRAL = int1 - int2 + int3 - int4;
            Console.WriteLine(INTEGRAL); // выводим значение полученного интеграла на экран
            Console.ReadLine();
        }
    }
}

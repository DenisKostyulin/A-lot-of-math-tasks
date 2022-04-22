using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    delegate double fun1(double x, double y);//Объявляю два делегата для функции двух и одной переменной соотвественно
    delegate double fun2(double x);
    class doubleintegral1604
    {   
            static double intX(double x, fun2 f, fun2 g, fun1 h) //Метод, который считает определенный интеграл относительно "y" при заданном "х"
            {
                double eps = 1E-6;//ошибка усечения
                int n = 10, i;
                double y, t, s = 0,step;
                y = h(x,g(x)) + h(x,f(x));//считаем число "у" при заданном "х" от g(x) до f(x)
                step = (f(x) - g(x)) / n;//объясвляю шаг разбиения
                do
                {      //считаю определенный интеграл методом Симпсона
                    t = s;
                    n *= 2; step = (f(x) - g(x)) / n;
                    s = 0;
                    for (i = 1; i <= n - 1; i++)
                    {
                        if (i % 2 != 0)
                            s = s + 4 * h(x,g(x) + i * step);
                        else
                            s = s + 2 * h(x,g(x) + i * step);
                    }
                    s = step / 3 * (y + s);
                } while (Math.Abs(t - s) >= eps); 
                return s; 
            }
        static double Integral(double a,double b, fun2 f, fun2 g, fun1 h)//метод, который считает двойной интеграл (с обращением к intX())
        {
            double eps = 1E-6;
            int n1 = 10, j;
            double y1, t1, s1 = 0, step1;
            y1 = intX(a,f,g,h)+ intX(b,f,g,h);//intX()- функция одной переменной , каждое значение которой это определенный интеграл при заданном "х" относительно "у"
            do
            {           //считаю интеграл методом Симпсона
                t1 = s1;
                n1 *= 2; step1 = (b - a) / n1;
                s1 = 0;
                for (j = 1; j <= n1 - 1; j++)
                {
                    if (j % 2 != 0)
                        s1 = s1 + 4 * intX(a+j*step1,f,g,h);
                    else
                        s1 = s1 + 2 * intX(a + j * step1,f,g,h);
                }
                s1 = step1 / 3 * (y1 + s1);
            } while (Math.Abs(t1 - s1) >= eps); 
            return s1; 
        }
        static double exp(double x, double y)//объявляю функции
        {
            return (Math.Exp(-y)*Math.Pow(y,(x-1)));
        }
        static double f2 (double x)
        {
            return (1 + x * x);
        }
        static double f1 (double x)
        {
            return 1;
        }
            static void Main(string[] args)
            {
            double a = 0, b = 5;//объявляю пределы
            double DOUBLEINTEGRAL=Integral(a,b,f2,f1,exp);//считаю двойной интеграл от заданной функции с заданными пределами
            Console.WriteLine(DOUBLEINTEGRAL);// Ответ: 17.7261
            Console.ReadLine();
            }
    }
}

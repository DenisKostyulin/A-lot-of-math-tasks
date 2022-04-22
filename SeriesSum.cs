using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace limit
{
    class limitclass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задачи, которую вы хотите решить(учтите,что в блоке нумерация идет слева направо, вдоль строчки и по порядку): ");
            label:
            int problem = int.Parse(Console.ReadLine());
            if(problem>21||problem<=1)
            { Console.WriteLine("Введите еще раз!"); goto label;}
            double currTerm; double controlValue; double sum = Switch(problem, out controlValue, out currTerm);
            Console.WriteLine($"Текущая сумма последовательности №{problem}: Current Term={sum - 1}");
            Console.WriteLine($"Контрольное значение суммы последовательности №{problem}: Control Value={controlValue}");
            double g = 100 * currTerm / (sum - 1);
            Console.WriteLine($"Погрешность приблизительно равна={g:g2}%");      
            Console.ReadKey(true);
        }
        public static double Factorial12(int k)
        {
            int v = 1; int start = k;
            while (start > 1)
            {
                v *= start;
                start--;
            }
            return v;
        }
        public static double Factorial34(int k)
        {
            int v = 1; int start = 2 * k;
            while (start > 1)
            {
                v *= start;
                start--;
            }
            return v;
        }
        public static double Factorial56(int k)
        {
            int v = 1; int start = (2 * k) - 1;
            while (start > 1)
            {
                v *= start;
                start--;
            }
            return v;
        }
        public static double Switch(int problem, out double controlValue, out double currTerm)
        {
            int m = 1; int k = 0; double sum = 1; controlValue = 1; currTerm = 1; double f = 1; float a = 1;
            float truncErr = 0.000000001f;
            if (problem == 20)
            {
                Console.WriteLine("Введите переменную m в последовательности №20 (m>0): ");
                m = int.Parse(Console.ReadLine());
                int start = m;
                while (start > 1)
                {
                    f *= start;
                    start--;
                }
            }
            if (problem == 21)
            {
                Console.WriteLine("Введите переменную a в последовательности №21(учтите, что введенная переменная должна удовлет. условию -1<a<1): ");
                mark:
                a = float.Parse(Console.ReadLine());
                while (a>1||a<-1)
                {Console.WriteLine("Введите еще раз!");
                    goto mark; }
            }
            if (problem == 1 || problem == 2 || problem == 3 || problem == 4)
            {
                while (Math.Abs(currTerm / (1 + sum)) > truncErr)
                {
                    k++;
                    switch (problem)
                    {
                        case 1:
                            controlValue = Math.Exp(1);
                            currTerm = 1 / Factorial12(k);
                            sum += currTerm;
                            break;
                        case 2:
                            controlValue = Math.Exp(-1);
                            currTerm = (Math.Pow((-1), k)) / Factorial12(k);
                            sum += currTerm;
                            break;
                        case 3:
                            controlValue = (Math.Exp(1) + Math.Exp(-1)) / 2;
                            currTerm = 1 / Factorial34(k);
                            sum += currTerm;
                            break;
                        case 4:
                            controlValue = Math.Cos(1);
                            currTerm = (Math.Pow((-1), k)) / Factorial34(k);
                            sum += currTerm;
                            break;
                    }
                }
                sum++;
            }
            else
            {
                while (Math.Abs(currTerm / sum) > truncErr)
                {
                    k++;
                    switch (problem)
                    {
                        case 7:
                            controlValue = (Math.Pow((Math.PI), 2)) / 6.0;
                            currTerm = 1.0 / (Math.Pow(k, 2));
                            sum += currTerm;
                            break;
                        case 8:
                            controlValue = (Math.Pow((Math.PI), 2)) / 8.0;
                            currTerm = 1.0 / (Math.Pow((2 * k - 1), 2));
                            sum += currTerm;
                            break;
                        case 9:
                            controlValue = (Math.Pow((Math.PI), 2)) / 12.0;
                            currTerm = (Math.Pow((-1), (k + 1))) / (Math.Pow(k, 2));
                            sum += currTerm;
                            break;
                        case 10:
                            controlValue = (Math.Pow((Math.PI), 4)) / 90.0;
                            currTerm = 1.0 / (Math.Pow(k, 4));
                            sum += currTerm;
                            break;
                        case 11:
                            controlValue = (Math.Pow((Math.PI), 6)) / 945.0;
                            currTerm = 1.0 / (Math.Pow(k, 6));
                            sum += currTerm;
                            break;
                        case 12:
                            controlValue = (Math.Pow((Math.PI), 8)) / 9450.0;
                            currTerm = 1.0 / (Math.Pow(k, 8));
                            sum += currTerm;
                            break;
                        case 13:
                            controlValue = Math.Log(2);
                            currTerm = (Math.Pow((-1), (k - 1))) / k;
                            sum += currTerm;
                            break;
                        case 14:
                            controlValue = (Math.PI) / 4.0;
                            currTerm = (Math.Pow((-1), (k - 1))) / (2 * k - 1);
                            sum += currTerm;
                            break;
                        case 15:
                            controlValue = (Math.Pow((Math.PI), 3)) / 32.0;
                            currTerm = (Math.Pow((-1), (k - 1))) / (Math.Pow((2 * k - 1), 3));
                            sum += currTerm;
                            break;
                        case 16:
                            controlValue = 1;
                            currTerm = 1.0 / k / (k + 1);
                            sum += currTerm;
                            break;
                        case 17:
                            controlValue = .5;
                            currTerm = 1.0 / (2 * k - 1) / (2 * k + 1);
                            sum += currTerm;
                            break;
                        case 18:
                            k++;
                            controlValue = .75;
                            currTerm = 1.0 / (k - 1) / (k + 1);
                            sum += currTerm; k--;
                            break;
                        case 19:
                            controlValue = .25;
                            currTerm = 1.0 / k / (k + 1) / (k + 2);
                            sum += currTerm;
                            break;
                        case 20:
                            controlValue = 1 / (m * f);
                            currTerm = 1;
                            for (int x = 0; x <= m; x++)
                            {
                                currTerm /= k + x;
                            }
                            sum += currTerm;
                            break;
                        case 21:
                            k--;
                            controlValue = 1 / (1 - a);
                            currTerm = Math.Pow(a, k);
                            sum += currTerm;
                            k++;
                            break;
                        case 5:
                            controlValue = (Math.Exp(1) - Math.Exp(-1)) / 2;
                            currTerm = 1 / Factorial56(k);
                            sum += currTerm;
                            break;
                        case 6:
                            controlValue = Math.Sin(1);
                            currTerm = (Math.Pow((-1), (k - 1))) / Factorial56(k);
                            sum += currTerm;
                            break;
                    }
                }
            }
            return sum;
        }
    }
}

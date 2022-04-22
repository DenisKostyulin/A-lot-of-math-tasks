using System;
//#define FinitSum
//#define SeriesSum
using System.IO;
using System.Text;

namespace LIMSUM
{
    class LimSumclass
    {
        #region FinitSum
#if FinitSum
        public static void Main(string[] args)
        {
            StringBuilder report = new StringBuilder();
            string curText;    //вспомогательная переменная для записи полученных значений     
            Random rnd = new Random();// Значения числа , до которого будет производится счет
            int k = rnd.Next(1, 10);//задается рандомно в интервале от 1 до 10
            Console.WriteLine(curText = $"k={k}");
            report.AppendLine(curText);
            int problem;// Номер проблемы, которую необходимо решить
            int i;//вспомогательная переменная при подсчете ControlValue
            int f = 1;// номер блока
            double cv;//ControlValue
            double s;// CurrTerm
            for (; f <= 6; f++)//перебираем все блоки
            {
                problem = 0;//Номер проблемы
                if (f == 1)
                {
                    for (; problem <= 10; problem++)//перебираем все проблемы
                    {
                        cv = 0;
                        s = 0;
                        for (i = 1; i <= k; i++)//считаем control Value
                        {
                            cv += Math.Pow(i, problem);
                        }
                        switch (problem)//считаем current Term 
                        {
                            case 0:
                                s = k;
                                break;
                            case 1:
                                s = (Math.Pow(k, 2) / 2) + k / 2.0;
                                break;
                            case 2:
                                s = (Math.Pow(k, 3) / 3.0) + (Math.Pow(k, 2) / 2.0) + k / 6.0;
                                break;
                            case 3:
                                s = (Math.Pow(k, 4) / 4.0) + (Math.Pow(k, 3) / 2.0) + (Math.Pow(k, 2) / 4.0);
                                break;
                            case 4:
                                s = (Math.Pow(k, 5) / 5.0) + (Math.Pow(k, 4) / 2.0) + (Math.Pow(k, 3) / 3.0) - (k / 30.0);
                                break;
                            case 5:
                                s = (Math.Pow(k, 6) / 6.0) + (Math.Pow(k, 5) / 2.0) + 5 * (Math.Pow(k, 4) / 12.0) - (Math.Pow(k, 2) / 12.0);
                                break;
                            case 6:
                                s = (Math.Pow(k, 7) / 7.0) + (Math.Pow(k, 6) / 2.0) + (Math.Pow(k, 5) / 2.0) - (Math.Pow(k, 3) / 6.0) + k / 42.0;
                                break;
                            case 7:
                                s = (Math.Pow(k, 8) / 8.0) + (Math.Pow(k, 7) / 2.0) + 7 * (Math.Pow(k, 6) / 12.0) - 7 * (Math.Pow(k, 4) / 24.0) + (Math.Pow(k, 2) / 12.0);
                                break;
                            case 8:
                                s = (Math.Pow(k, 9) / 9.0) + (Math.Pow(k, 8) / 2.0) + 2 * (Math.Pow(k, 7) / 3.0) - 7 * (Math.Pow(k, 5) / 15.0) + 2 * (Math.Pow(k, 3) / 9.0) - k / 30.0;
                                break;
                            case 9:
                                s = ((Math.Pow(k, 10)) / 10) + ((Math.Pow(k, 9)) / 2) + 3 * ((Math.Pow(k, 8)) / 4) - 7 * ((Math.Pow(k, 6)) / 10) + ((Math.Pow(k, 4)) / 2) - 3 * ((Math.Pow(k, 2)) / 20.0);
                                break;
                            case 10:
                                s = (Math.Pow(k, 11) / 11.0) + (Math.Pow(k, 10) / 2.0) + 5 * (Math.Pow(k, 9) / 6.0) - (Math.Pow(k, 7.0)) + (Math.Pow(k, 5)) - (Math.Pow(k, 3) / 2.0) + (5 * (k / 66.0));
                                break;
                        }
                        Console.WriteLine(curText = $"Number of the block= {f}\n  " + $"Number of the problem= {problem}\n  " + $"Control Value= {cv}\n  " + $"Current Term=  {s}\n  ");
                        report.AppendLine(curText);//каждый раз после полученных значений я записываю их в report
                    }
                }
                if (f == 2)
                {
                    for (; problem <= 10; problem++)
                    {
                        cv = 0;
                        s = 0;
                        for (i = 1; i <= k; i++)
                        {
                            cv += Math.Pow((2 * i - 1), problem);
                        }
                        switch (problem)
                        {
                            case 0:
                                s = k;
                                break;
                            case 1:
                                s = 2 * (Math.Pow(k, 2) / 2.0);
                                break;
                            case 2:
                                s = 4 * (Math.Pow(k, 3) / 3.0) - k / 3.0;
                                break;
                            case 3:
                                s = 8 * (Math.Pow(k, 4) / 4.0) - Math.Pow(k, 2);
                                break;
                            case 4:
                                s = 16 * (Math.Pow(k, 5) / 5.0) - 8 * (Math.Pow(k, 3) / 3.0) + (7 * (k / 15.0));
                                break;
                            case 5:
                                s = 32 * (Math.Pow(k, 6) / 6.0) - 20 * (Math.Pow(k, 4) / 3.0) + 7 * (Math.Pow(k, 2) / 3.0);
                                break;
                            case 6:
                                s = 64 * (Math.Pow(k, 7) / 7.0) - 16 * (Math.Pow(k, 5.0)) + 28 * (Math.Pow(k, 3) / 3.0) - (31 * (k / 21.0));
                                break;
                            case 7:
                                s = 16 * (Math.Pow(k, 8)) - 112 * (Math.Pow(k, 6) / 3.0) + 98 * (Math.Pow(k, 4) / 3.0) - 31 * (Math.Pow(k, 2) / 3.0);
                                break;
                            case 8:
                                s = 256 * (Math.Pow(k, 9) / 9.0) - 256 * (Math.Pow(k, 7) / 3.0) + 1568 * (Math.Pow(k, 5) / 15.0) - 496 * (Math.Pow(k, 3) / 9) + 127 * (k / 15.0);
                                break;
                            case 9:
                                s = 512 * (Math.Pow(k, 10) / 10.0) - 192 * (Math.Pow(k, 8)) + 1568 * (Math.Pow(k, 6) / 5.0) - 248 * ((Math.Pow(k, 4))) + 381 * (Math.Pow(k, 2) / 5.0);
                                break;
                            case 10:
                                s = 1024 * (Math.Pow(k, 11) / 11.0) - 1280 * (Math.Pow(k, 9) / 3.0) + 986 * (Math.Pow(k, 7)) - 992 * (Math.Pow(k, 5)) + 508 * (Math.Pow(k, 3)) - ((2555 * k) / 33.0);//неправильная формула, нужно найти не могу
                                break;
                        }
                        Console.WriteLine(curText = $"Number of the block= {f}\n  " + $"Number of the problem= {problem}\n  " + $"Control Value= {cv}\n  " + $"Current Term=  {s}\n  ");
                        report.AppendLine(curText);
                    }
                }
                if (f == 3)
                {
                    for (problem = 2; problem <= 10; problem += 2)
                    {
                        cv = 0;
                        s = 0;
                        for (i = 1; i <= k; i++)
                        {
                            cv += (Math.Pow(-1, i - 1)) * Math.Pow(i, problem);
                        }
                        if (k % 2 == 0)//выбираем блок в зависимости от четности
                        {
                            switch (problem)
                            {
                                case 2:
                                    s = -((Math.Pow(k, 2)) / 2.0) - (k / 2.0);
                                    break;
                                case 4:
                                    s = -((Math.Pow(k, 4)) / 2.0) - (Math.Pow(k, 3)) + (k / 2.0);
                                    break;
                                case 6:
                                    s = -((Math.Pow(k, 6)) / 2.0) - 3 * ((Math.Pow(k, 5)) / 2.0) + 5 * ((Math.Pow(k, 3)) / 2.0) - (3 * k / 2.0);
                                    break;
                                case 8:
                                    s = -((Math.Pow(k, 8)) / 2.0) - 2 * (Math.Pow(k, 7)) + 7 * (Math.Pow(k, 5)) - 14 * (Math.Pow(k, 3)) + 17 * (k / 2.0);
                                    break;
                                case 10:
                                    s = -((Math.Pow(k, 10)) / 2.0) - 5 * ((Math.Pow(k, 9)) / 2.0) + 15 * (Math.Pow(k, 7)) - 63 * (Math.Pow(k, 5)) + 255 * ((Math.Pow(k, 3)) / 2.0) - (155 * k / 2.0);
                                    break;
                            }
                        }
                        else
                        {
                            switch (problem)
                            {
                                case 2:
                                    s = ((Math.Pow(k, 2)) / 2.0) + (k / 2.0);
                                    break;
                                case 4:
                                    s = ((Math.Pow(k, 4)) / 2.0) + (Math.Pow(k, 3)) - (k / 2.0);
                                    break;
                                case 6:
                                    s = ((Math.Pow(k, 6)) / 2.0) + 3 * ((Math.Pow(k, 5)) / 2.0) - 5 * ((Math.Pow(k, 3)) / 2.0) + (3 * k / 2.0);
                                    break;
                                case 8:
                                    s = ((Math.Pow(k, 8)) / 2.0) + 2 * (Math.Pow(k, 7)) - 7 * (Math.Pow(k, 5)) + 14 * (Math.Pow(k, 3)) - 17 * (k / 2.0);
                                    break;
                                case 10:
                                    s = ((Math.Pow(k, 10)) / 2.0) + 5 * ((Math.Pow(k, 9)) / 2.0) - 15 * (Math.Pow(k, 7)) + 63 * (Math.Pow(k, 5)) - 255 * ((Math.Pow(k, 3)) / 2.0) + (155 * k / 2.0);
                                    break;
                            }
                        }
                        Console.WriteLine(curText = $"Number of the block= {f}\n  " + $"Number of the problem= {problem}\n  " + $"Control Value= {cv}\n  " + $"Current Term=  {s}\n  ");
                        report.AppendLine(curText);
                    }
                }
                if (f == 4)
                {
                    for (problem = 1; problem <= 9; problem += 2)
                    {
                        cv = 0;
                        s = 0;
                        for (i = 1; i <= k; i++)
                        {
                            cv += (Math.Pow(-1, i - 1)) * Math.Pow(2 * i - 1, problem);
                        }
                        if (k % 2 == 0)
                        {
                            switch (problem)
                            {
                                case 1:
                                    s = -k;
                                    break;
                                case 3:
                                    s = -4 * (Math.Pow(k, 3)) + (3 * k);
                                    break;
                                case 5:
                                    s = -16 * (Math.Pow(k, 5)) + 40 * (Math.Pow(k, 3)) - (25 * k);
                                    break;
                                case 7:
                                    s = -64 * (Math.Pow(k, 7)) + 336 * (Math.Pow(k, 5)) - 700 * (Math.Pow(k, 3)) + (427 * k);
                                    break;
                                case 9:
                                    s = -256 * (Math.Pow(k, 9)) + 2304 * (Math.Pow(k, 7)) - 10080 * (Math.Pow(k, 5)) + 20496 * (Math.Pow(k, 3)) - (12465 * k);
                                    break;

                            }
                        }
                        else
                        {
                            switch (problem)
                            {
                                case 1:
                                    s = k;
                                    break;
                                case 3:
                                    s = 4 * (Math.Pow(k, 3)) - (3 * k);
                                    break;
                                case 5:
                                    s = 16 * (Math.Pow(k, 5)) - 40 * (Math.Pow(k, 3)) + (25 * k);
                                    break;
                                case 7:
                                    s = 64 * (Math.Pow(k, 7)) - 336 * (Math.Pow(k, 5)) + 700 * (Math.Pow(k, 3)) - (427 * k);
                                    break;
                                case 9:
                                    s = 256 * (Math.Pow(k, 9)) - 2304 * (Math.Pow(k, 7)) + 10080 * (Math.Pow(k, 5)) - 20496 * (Math.Pow(k, 3)) + (12465 * k);
                                    break;
                            }
                        }
                        Console.WriteLine(curText = $"(Number of the block= {f}\n  " + $"Number of the problem= {problem}\n  " + $"Control Value= {cv}\n  " + $"Current Term=  {s})\n  ");
                        report.AppendLine(curText);
                    }
                }
                if (f == 5)
                {
                    for (problem = 2; problem <= 5; problem++)
                    {
                        cv = 0;
                        s = 0;
                        for (i = 0; i <= k - 1; i++)
                        {
                            switch (problem)
                            {
                                case 2:
                                    cv += 1 + 2 * i;
                                    break;
                                case 3:
                                    cv += 1 + 3 * i + 3 * (Math.Pow(i, 2));
                                    break;
                                case 4:
                                    cv += 1 + 4 * i + 6 * (Math.Pow(i, 2)) + 4 * (Math.Pow(i, 3));
                                    break;
                                case 5:
                                    cv += 1 + 5 * i + 10 * (Math.Pow(i, 2)) + 10 * (Math.Pow(i, 3)) + 5 * (Math.Pow(i, 4));
                                    break;
                            }

                        }
                        s = Math.Pow(k, problem);
                        Console.WriteLine(curText = $"(Number of the block= {f}\n  " + $"Number of the problem= {problem}\n  " + $"Control Value= {cv}\n  " + $"Current Term=  {s})\n  ");
                        report.AppendLine(curText);
                    }
                }
                if (f == 6)
                {
                    for (problem = 2; problem <= 5; problem++)
                    {
                        cv = 0;
                        s = 0;
                        for (i = 1; i <= k; i++)
                        {
                            switch (problem)
                            {
                                case 2:
                                    cv += (2 * i) - 1;
                                    break;
                                case 3:
                                    cv += 3 * (Math.Pow(i, 2)) + 1 - 3 * i;
                                    break;
                                case 4:
                                    cv += 4 * (Math.Pow(i, 3)) - 1 + 4 * i - 6 * (Math.Pow(i, 2));
                                    break;
                                case 5:
                                    cv += 1 - 5 * i + 10 * (Math.Pow(i, 2)) - 10 * (Math.Pow(i, 3)) + 5 * (Math.Pow(i, 4));
                                    break;
                            }

                        }
                        s = Math.Pow(k, problem);
                        Console.WriteLine(curText = $"(Number of the block= {f}\n  " + $"Number of the problem= {problem}\n  " + $"Control Value= {cv}\n  " + $"Current Term=  {s})\n  ");
                        report.AppendLine(curText);
                        cv = 0;
                        s = 0;
                    }
                }
            }
            Console.SetOut(File.CreateText("FinitSumReport.txt"));//Запись отчета о полученных и введенных данных в report
            Console.WriteLine(report);
            Console.Out.Close();
            Console.ReadLine();
        }
#endif
        #endregion
        #region SeriesSum
#if SeriesSum

        public static void Main(string[] args)
        {
            StringBuilder report = new StringBuilder();
            string curText;//вспомогательная переменная для записи полученных значений
            int problem = 1;
            for (; problem <= 21; problem++)//перебираем все проблемы
            {
                double currTerm; double controlValue; double sum = Switch(problem, out controlValue, out currTerm);//вызываем метод с возвращенным значением 
                double g = 100 * currTerm / (sum - 1);//считаем погрешность в процентах, так нагляднее
                Console.WriteLine(curText = $"Number of the problem: {problem}  \n" + $"Current Term={sum - 1} \n" + $"Control Value={controlValue}  \n" + $"the error is approximately equal ={g:g2}%\n");
                report.AppendLine(curText);//обобщаем операцию записи полученных значений
            }
            Console.SetOut(File.CreateText("SeriesSumReport.txt"));
            Console.WriteLine(report);//записываем все значения 
            Console.Out.Close();
            Console.ReadKey(true);
        }
        public static double Factorial12(int k)
        {
            int v = 1; int start = k;//считаем факториал k
            while (start > 1)
            {
                v *= start;//вспомогательная переменная для подсчета факториала
                start--;
            }
            return v;
        }
        public static double Factorial34(int k)
        {
            int v = 1; int start = 2 * k;
            while (start > 1)//считаем факториал 2*k
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
                v *= start;//считаем факториал (2*k)-1
                start--;
            }
            return v;
        }
        public static double Switch(int problem, out double controlValue, out double currTerm)
        {
            int m = 1; int k = 0; double sum = 1; controlValue = 1; currTerm = 1; double f = 1; double a = 0.5;
            float truncErr = 0.0000001f;//будем считать предел суммы с заданной точностью(счет суммы продолжается пока отношение currTerm и sum больше заданного числа)
            if (problem == 20)
            {
                Random rnd = new Random();
                m = rnd.Next(1, 15);//подбираем нужную переменную рандомно(берем не очень большие числа, потому что возможно переполнение)
                int start = m;
                while (start > 1)
                {
                    f *= start;//считаем факториал m
                    start--;
                }
            }
            if (problem == 1 || problem == 2 || problem == 3 || problem == 4)
            {
                while (Math.Abs(currTerm / (1 + sum)) > truncErr)//т.к. у всех сумм k начальное 0, а у 1,2,3,4 проблем с 1, то я создал отдельный цикл
                {
                    k++;
                    switch (problem)
                    {
                        case 1:
                            controlValue = Math.Exp(1);//экспонента в степени 1
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
                            controlValue = Math.Cos(1);//косинус с углом 1 град.
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
                            controlValue = (Math.Pow((Math.PI), 2)) / 6.0;//число П
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
                            currTerm = 1;
                            controlValue = 1 / (m * f);
                            for (int x = 0; x <= m; x++)//т.к. k в дроби постоянно меняется, то будем каждый раз обновлять число и добавлять его к sum
                            {
                                currTerm /= k + x;
                            }
                            sum += currTerm;
                            break;
                        case 21:
                            k--;//единственный случай отличия k, чтобы сильно не менять код, осуществляем такую операцию
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
                            controlValue = Math.Sin(1);//синус с углом 1
                            currTerm = (Math.Pow((-1), (k - 1))) / Factorial56(k);
                            sum += currTerm;
                            break;
                    }
                }
            }
            return sum;//возвращаем полученное значение sum
        }

#endif
        #endregion
    }
}

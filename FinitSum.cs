using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Summaryada
{
    class summaclass
    {
        public static void Main(string[] args)
        {
            double s = 0;
            bool m=true;
            int k = 0;
            int problem = 0;
            int i = 0;
            double cv = 0;
            Console.WriteLine("Enter the number of the block: ");
            int f = int.Parse(Console.ReadLine());
           
            if (f == 1)
            {
                Console.WriteLine("Enter the quantity of number of numbers in the series: ");
                k = int.Parse(Console.ReadLine());
                Console.Write("Enter number of the problem, which will mean the degree each of number in the series = ");
                problem = int.Parse(Console.ReadLine());
                for (; i <= k; i++)
                {
                    cv += Math.Pow(i, problem);
                }
                if (problem<=10 && problem>=0)
                {
                    m = true;
                }
                else
                {
                    m = false;
                }
                switch (problem)
                {
                    case 0:
                        s= k;
                        break;
                    case 1:
                        s = (Math.Pow(k, 2) / 2) + k / 2.0;
                        break;
                    case 2:
                        s = (Math.Pow(k, 3) / 3) + (Math.Pow(k, 2) / 2) + k / 6.0;
                        break;
                    case 3:
                        s = (Math.Pow(k, 4) / 4) + (Math.Pow(k, 3) / 2) + (Math.Pow(k, 2) / 4);
                        break;
                    case 4:
                        s = (Math.Pow(k, 5) / 5) + (Math.Pow(k, 4) / 2) + (Math.Pow(k, 3) / 3) - (k / 30.0);
                        break;
                    case 5:
                        s = (Math.Pow(k, 6) / 6) + (Math.Pow(k, 5) / 2) + 5 * (Math.Pow(k, 4) / 12) - (Math.Pow(k, 2) / 12);
                        break;
                    case 6:
                        s = (Math.Pow(k, 7) / 7) + (Math.Pow(k, 6) / 2) + (Math.Pow(k, 5) / 2) - (Math.Pow(k, 3) / 6) + k / 42.0;
                        break;
                    case 7:
                        s = (Math.Pow(k, 8) / 8) + (Math.Pow(k, 7) / 2) + 7 * (Math.Pow(k, 6) / 12) - 7 * (Math.Pow(k, 4) / 24) + (Math.Pow(k, 2) / 12);
                        break;
                    case 8:
                        s = (Math.Pow(k, 9) / 9) + (Math.Pow(k, 8) / 2) + 2 * (Math.Pow(k, 7) / 3) - 7 * (Math.Pow(k, 5) / 15) + 2 * (Math.Pow(k, 3) / 9) - k / 30.0;
                        break;
                    case 9:
                        s= ((Math.Pow(k, 10)) / 10) + ((Math.Pow(k, 9)) / 2) + 3 * ((Math.Pow(k, 8)) / 4) - 7 * ((Math.Pow(k, 6)) / 10) + ((Math.Pow(k, 4)) / 2) - 3 * ((Math.Pow(k, 2)) / 20.0);
                        break;
                    case 10:
                        s = (Math.Pow(k, 11) / 11)+ (Math.Pow(k, 10) / 2) + 5 * (Math.Pow(k, 9) / 6) - (Math.Pow(k, 7)) + (Math.Pow(k, 5)) - (Math.Pow(k, 3) / 2) + (5 * (k / 66));
                        break;
                    default:
                        Console.WriteLine("Number of the problem was entered wrong!");
                        break;
                }
            }
            if (f == 2)
            {
                Console.WriteLine("Enter the quantity of number of numbers in the series: ");
                k = int.Parse(Console.ReadLine());
                Console.Write("Enter number of the problem = ");
                problem = int.Parse(Console.ReadLine());
                for (i = 1; i <= k; i++)
                {
                    cv += Math.Pow((2 * i - 1), problem);
                }
                if (problem>=0 && problem<=10)
                {
                    m = true;
                }
                else
                {
                    m = false;
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
                        s = 1024 * (Math.Pow(k, 11) / 11.0) - 1280 * (Math.Pow(k, 9) / 3.0) + 986 * (Math.Pow(k, 7)) - 992 * (Math.Pow(k, 5)) + 508 * (Math.Pow(k, 3)) - 2555 * (k / 33.0);
                        break;
                    default:
                        Console.WriteLine("Number of the problem was entered wrong!");
                        break;
                }
            }
            if (f == 3)
            {
                Console.WriteLine("Enter the quantity of number of numbers in the series: ");
                k = int.Parse(Console.ReadLine());
                Console.Write("Enter number of the problem = ");
                problem = int.Parse(Console.ReadLine());
                for (; i <= k; i++)
                {
                    cv += (Math.Pow(-1, i - 1)) * Math.Pow(i, problem);
                }
                if (k % 2 == 0)
                {
                    if (problem % 2 == 0 && problem >= 2 && problem <= 10)
                    {
                        m = true;
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
                        m = false;
                    }
                }
                else
                {
                    if (problem % 2 == 0 && problem >= 2 && problem <= 10)
                    {
                        m = true;
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
                    else
                    {
                        m = false;
                    }
                }
            }
            if (f == 4)
            {
                Console.WriteLine("Enter the quantity of number of numbers in the series: ");
                k = int.Parse(Console.ReadLine());
                Console.Write("Enter number of the problem = ");
                problem = int.Parse(Console.ReadLine());
                for (i = 1; i <= k; i++)
                {
                    cv += (Math.Pow(-1, i - 1)) * Math.Pow(2 * i - 1, problem);
                }
                if (k % 2 == 0)
                {
                    if (problem % 2 == 1 && problem >= 1 && problem <= 9)
                    {
                        m = true;
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
                        m = false;
                    }
                }
                else
                {
                    if (problem % 2 == 1 && problem >= 1 && problem <= 9)
                    {
                        m = true;
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
                    else
                    {
                        m = false;
                    }
                }
            }
            if (f==5)
            {
                Console.WriteLine("Enter the quantity of number of numbers in the series: ");
                k = int.Parse(Console.ReadLine());
                Console.Write("Enter number of the problem = ");
                problem = int.Parse(Console.ReadLine());
                for (i = 0; i <= k-1; i++)
                {
                    switch (problem)
                    {
                        case 2:
                            cv += 1 + 2 * i;
                            break;
                        case 3:
                            cv +=1+3*i+3*(Math.Pow(i,2));
                            break;
                        case 4:
                            cv += 1+4*i+6* (Math.Pow(i,2)) + 4*(Math.Pow(i,3));
                            break;
                        case 5:
                            cv +=1+5*i+10*(Math.Pow(i,2))+10*(Math.Pow(i,3))+5*(Math.Pow(i,4)); 
                                break;
                    }

                }
                if (problem >= 2 && problem <= 5)
                {
                    m = true;
                }
                else
                {
                    m = false;
                }               
                        s = Math.Pow(k,problem);                 
            }
            if (f == 6)
            {
                Console.WriteLine("Enter the quantity of number of numbers in the series: ");
                k = int.Parse(Console.ReadLine());
                Console.Write("Enter number of the problem = ");
                problem = int.Parse(Console.ReadLine());
                for (i = 1; i <= k; i++)
                {
                    switch (problem)
                    {
                        case 2:
                            cv +=(2 * i)-1;
                            break;
                        case 3:
                            cv +=3 * (Math.Pow(i, 2))+1 - 3 * i;
                            break;
                        case 4:
                            cv +=4 * (Math.Pow(i, 3)) -1 + 4 * i - 6 * (Math.Pow(i, 2));
                            break;
                        case 5:
                            cv += 1 - 5 * i + 10 * (Math.Pow(i, 2)) - 10 * (Math.Pow(i, 3)) + 5 * (Math.Pow(i, 4));
                            break;
                    }

                }
                if (problem >= 2 && problem <= 5)
                {
                    m = true;
                }
                else
                {
                    m = false;
                }
                s = Math.Pow(k, problem);
            }
            if (m == true)
            {
                Console.WriteLine($"Number of the block = {f}");
                Console.WriteLine($"Quantity of number of numbers in the series = {k}");
                Console.WriteLine($"Number of the problem = {problem}");
                Console.WriteLine($"Current Term= {s}");
                Console.WriteLine($"Control Value={cv}");
            }
            else
            {
                Console.WriteLine("Error!");
            }
            Console.ReadLine();
        }     
    }
}
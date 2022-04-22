using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class задача2_1704
    {
        static double sum(double[] x,int low,int up)
        {
            double res=0;
            for(int i = low; i < up; i++)
            {
                res +=x[i]*x[i];
            }
            return res;
        }
        static double multi(double[] x,double[] y, int low, int up)
        {
            double res = 0;
            for (int i = low; i < up; i++)
            {
                res += x[i] * y[i];
            }
            return res;
        }
        static void Main(string[] args)
        {
            double[] x = { 1, 5, 6, 7, 9, 12, 4, 6, 2, 4, 7, 2, 3, 15, 12, 3, 5, 12, 6, 8 };
            double[] y = { 2, 3, 4, 8, 10, 11, 4, 7, 2, 7, 13, 4, 6, 8, 13, 6, 3, 8, 15, 6 };
            double u = multi(x, y, 1, 15) > 0 ? sum(x, 1, 20): sum(y, 14, 20);
            Console.WriteLine(u);
            Console.ReadKey(true);
        }
    }
}

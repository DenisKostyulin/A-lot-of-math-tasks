using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 6,i,j,c;
            int [] T0 = {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            int [] T1 = {0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            int [] Tn = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            for(i=2;i<=k;i++)
            {
                for(j = 0; j <= k; j++)
                {
                    Tn[j] = T1[j] * 2;
                }
                for (j =k ; j >0 ; j--)
                {
                    Tn[j] = Tn[j - 1];
                }
                Tn[0] = 0;
                for (j = 0; j <= k; j++)
                {
                    Tn[j] = Tn[j] - T0[j];
                    T0[j] = T1[j];
                    T1[j] = Tn[j];
                }
            }
            for (j = 0; j <= k; j++)
            {
                Console.Write(Tn[j]+" ");
            }
            Console.ReadLine();
        }
    }
}

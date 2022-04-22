using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        { 
            int i,j,c=0;
            int [] x = new int[10000];
            for (i = 0; i < 10000; i++)
            {
                x[i] = 1;
            }
            double s = x[0];
            for (i=1;i<100;i++)
            {
                for (j=i*i;j<(i+1)*(i+1);j++)
                {
                    c += x[j];
                }
                s *= c;
                c = 0;
            }
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}

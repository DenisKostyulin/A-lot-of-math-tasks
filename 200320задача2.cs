using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j,k,n=0;
            for (k = 1; k < 10; k++)
            {
                for (j = 0; j < 10; j++)
                {
                    for (i = 0; i < 10; i++)
                    {
                        if(((i+j+k)<=27)&& ((i + j + k) >= 1))
                        {
                            n++;
                        }
                    }
                }
            }
            Console.WriteLine(n);
            Console.ReadLine();
        }
    }
}

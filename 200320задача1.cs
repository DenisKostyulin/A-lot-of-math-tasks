using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double s=0;
            for (i = 99; i > 2; i = i - 3)
            {
                s = Math.Sqrt(s + i);
            }
            Console.Write(s);
            Console.ReadLine();
        }
    }
}

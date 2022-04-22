using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class задача1б
    {
        static void Main(string[] args)
        {
            int k=20, i, j, A;
            int[] z = new int[k];
            for (i = 0; i < k; i++)
            {
                z[i] =k-i;
            }
            for (i = 0; i < k; i++)
            {
                for (j = 0; j < k - 1; j++)
                {
                    if (z[j] > z[j + 1])
                    {
                        A = z[j];
                        z[j] = z[j + 1];
                        z[j + 1] = A;
                    }
                }
            }
            foreach (int h in z)
            {
                Console.Write(h + " ");
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class задача1а
    {
        static void Main(string[] args)
        {

            int i, A, c = 0, B,u;
            int[] z = { 5, 6, 7,1,2,4,3,8,10,9,11,29,12,30,14,13,15,28,27,26,25,24,23,22,21,20,19,18,16,17 };
            int j = z.Length;
            for(u=0;u<z.Length-1;u++)
            { 
            A = z[c];
            for (i = c + 1; i < j; i++)
            {
                if (A < z[i])
                {
                    A = z[i];
                    c = i;
                }
            }
            B = z[j - 1];
            z[j - 1] = A;
            z[c] = B;
            j--; c = 0;
            }
            foreach (int h in z)
            {
                Console.Write(h + " ");
            }
            Console.ReadLine();
        }
    }
}

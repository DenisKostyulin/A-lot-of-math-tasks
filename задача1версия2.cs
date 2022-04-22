using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class задача1версия2
    {
        static void Main(string[] args)
        {
            int k =20, m =50, i, j, A;
            int[] x = new int[k];
            int[] y = new int[m];
            int[] z = new int[k + m];
            for (i = 0; i < k; i++)
            {
                x[i] = i +20;
            }
            for (i = 0; i < m; i++)
            {
                y[i] = i + 1;
            }
            for (i=0;i<k;i++)
            {
                z[i] = x[i];
            }
            j = k;
            for (i=0;i<m;i++)
            {
                z[j] = y[i];
                j++;
            }
            for (i = 0; i < k + m; i++)
            {
                for (j = 0; j < k + m - 1; j++)
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

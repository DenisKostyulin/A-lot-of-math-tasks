using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class задача1версия1
    {
        static void Main(string[] args)
        {
            int k = 20, m = 50, i,j=0,u=0;
            int[] x = new int[k];
            int[] y = new int[m];
            int[] z = new int[k + m];
            for (i = 0; i < k; i++)
            {
                x[i] =i+5;
            }
            for (i = 0; i < m; i++)
            {
                y[i] = i;
            }
            for (i = 0; i < k; i++)
            {
                    while ((j<m)&&(x[i] >= y[j]))
                    {
                        if (j < m)
                        {
                            z[u] = y[j];
                            u++; j++;
                        }
                        else
                        {
                            for (; i < k; i++)
                            {
                                z[u] = x[i];
                                u++;
                            }
                            goto label;
                        }
                    }
                z[u] = x[i];
                u++;
            }
            if (j < m)
            {
                for (; j < m; j++)
                {
                    z[u] = y[j];
                    u++;
                }
            }
            label:
            foreach (int h in z)
            {
                Console.Write(h+" ");
            }
            Console.ReadLine();
        }
    }
}

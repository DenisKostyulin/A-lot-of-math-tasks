using System;

namespace ConsoleApp43
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int i, j;
            double AmountOfFlights=0;
            double[][] rider = new double[7][];

            for (i = 0; i < 5; i++)
            {
                rider[i] = new double[10];
                for (j = 0; j < 10; j++)
                    rider[i][j] = rand.Next(1, 20);
            }

            for (i = 5; i < 7; i++)
            {
                rider[i] = new double[2];
                for (j = 0; j < 2; j++)
                    rider[i][j] = rand.Next(1, 20);
            }

            for (i = 0; i < 7; i++)
            {
                for (j=0;j<rider[i].Length;j++)
                {
                    Console.Write(rider[i][j]+"\t");
                }
                Console.WriteLine("\n");
            }

            for(i=0;i<7;i++)
                for (j = 0; j < rider[i].Length; j++)
                {
                    AmountOfFlights += rider[i][j];
                }
            Console.WriteLine("\n\nAmount of flights: "+AmountOfFlights);

            Console.ReadLine();
        }
    }
}

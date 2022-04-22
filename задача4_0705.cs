using System;

namespace ConsoleApp3
{
    class Massive
    {
        public static double MultiEven(double[] X, double[] Y,int size)//ЧЕТНЫЕ
        {
            double SumEven = 0;
            for (int i = 1; i < size; i += 2)
                SumEven += X[i] * Y[i];
            return SumEven;
        }
        public static double MultiOdd(double[] X, double[] Y,int size)//НЕЧЕТНЫЕ
        {
            double SumOdd = 0;
            for (int i = 0; i < size-1; i += 2)
                SumOdd += X[i] * Y[i];
            return SumOdd;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int size = 30;
            double[] X = new double[size];
            double[] Y = new double[size];  
            for(int i = 0; i < size; i++)
            {
                X[i] = 1;
                Y[i] = 2;
            }
            Console.WriteLine(Massive.MultiOdd(X,Y,size)/Massive.MultiEven(X, Y, size));
            Console.ReadLine();
        }
    }
}

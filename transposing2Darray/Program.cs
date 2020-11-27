using System;

namespace transposing2Darray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[5, 5]
                {
                    { 2,3,8,0,1 },
                    { 4,5,9,5,8 },
                    { 6,7,10,3,1},
                    { 1,7,4,0,5 },
                    { 6,8,0,3,8 }
                };

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = i+1; j <numbers.GetLength(1); j++)
                {
                    int swap = numbers[i, j];
                    numbers[i, j] = numbers[j, i];
                    numbers[j, i] = swap;
                }
            }

            

            Console.WriteLine();
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0} ", numbers[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            Console.ReadLine();



            int median = numbers.GetLength(0)/2;
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                int k = 0;
                for (int j = numbers.GetLength(0)-1; j > median; j--)
                {
                    
                    int swap = numbers[i, j];
                    numbers[i, j] = numbers[i, k];
                    numbers[i, k] = swap;
                    k++;
                }
            }

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0} ", numbers[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            Console.ReadLine();


        }
    }
}

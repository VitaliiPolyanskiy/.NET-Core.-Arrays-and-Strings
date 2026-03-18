using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[,] myArr2 = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[][] myArr3 =
            [
                [1,2,3],
                [1,2],
                [1,2,3,4]
            ];

            Console.WriteLine("One-dimensional array");
            foreach (int i in myArr1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nTwo-dimensional array");
            foreach (int i in myArr2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nJagged array");
            foreach (int[] arr in myArr3)
            {
                foreach (int j in arr)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
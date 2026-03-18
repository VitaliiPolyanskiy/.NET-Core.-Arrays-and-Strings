using System;

namespace CSharpApplication.two_dimensional_array
{
    class MainClass
    {
        static void Main()
        {
            // Створення двомірного масиву з 5x5 елементів типу int 
            // Усі елементи масиву ініціалізуються нулями
            int[,] intArray = new int[5, 5];
            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    Console.Write("{0,4}", intArray[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            // Створення та ініціалізація масиву 3x2
            int[,] intArray2 = new int[3, 2] { { 0, 3 }, { 7, 17 }, { 25, 0 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("{0,4}", intArray2[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            // Створення та ініціалізація (укорочений варіант)
            int[,,] intArray3 = new int[3, 2, 2] { { { 0, 3 }, { 7, 17 } }, { { 25, 0 }, { 0, 3 } }, { { 7, 17 }, { 25, 0 } } };
            for (int i = 0; i < intArray3.GetLength(0); i++)
            {
                for (int j = 0; j < intArray3.GetLength(1); j++)
                {
                    for (int k = 0; k < intArray3.GetLength(2); k++)
                    {
                        Console.Write("{0,4}", intArray3[i, j, k]);
                    }
                }
            }
            // Можна оголосити масив без ініціалізації
            int[,] arr3;
            // Але його не можна використовувати, доки він не створений за допомогою оператора new
            /*
            arr3[0,0] = 0; // Помилка компіляції
            arr3 = { {0, 3}, {7, 17}, {25, 0} }; // Помилка компіляції
            */
            arr3 = new int[,] { { 0, 3 }, { 7, 17 }, { 25, 0 } };
            arr3[0, 0] = 10;

        }
    }
}


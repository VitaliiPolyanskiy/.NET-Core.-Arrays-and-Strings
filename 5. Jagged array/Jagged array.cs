using System;

namespace CSharpApplication.array
{
    class MainClass
    {
        static void Main()
        {
            // Створення "зубчастого" масиву з 3 елементів
            int[][] intArray = new int[3][];
            for (int i = 0; i < intArray.Length; i++)
                // Кожен елемент містить одномірний масив із 5 елементів
                intArray[i] = new int[5];

            // Створення "зубчастого" непрямокутного масиву з 3 елементів
            float[][] floatArray = new float[3][];
            for (int i = 0; i < floatArray.Length; i++)
                // Кожний елемент містить одномірний масив з i + 1 елементів
                floatArray[i] = new float[i + 1];

            // Ініціалізація "зубчастих" масивів

            // Варіант 1
            int[][] intArray2 = new int[3][];
            intArray2[0] = new int[] { 1, 2, 3, 4, 5 };
            intArray2[1] = new int[] { 3, 4, 5 };
            intArray2[2] = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            for (int i = 0; i < intArray2.Length; i++)
            {
                for (int j = 0; j < intArray2[i].Length; j++)
                {
                    Console.Write("{0,4}", intArray2[i][j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            // Варіант 2
            int[][] intArray3 = new int[][]
            {
               new int[] {1, 2, 3, 4, 5},
               new int[] {3, 4, 5},
               new int[] {1, 2, 3, 4, 5, 6, 7}
            };

            // Варіант 3
            int[][] intArray4 =
            {
               new int[] {1, 2, 3, 4, 5},
               new int[] {3, 4, 5},
               new int[] {1, 2, 3, 4, 5, 6, 7}
            };

            // "Зубчасті" та "звичайні" масиви можна змішувати
            int[][,] myMixedArray = new int[][,]
            {
               new int[,] { {1, 2}, {3, 4} },
               new int[,] { {5, 6}, {7, 8}, {9, 10} },
               new int[,] { {11, 12} }
            };

            // Доступ до елемента масиву
            System.Console.WriteLine(myMixedArray[0][0, 0]);

            // Можна оголосити масив без ініціалізації
            int[][] arr3;
            // Але його не можна використовувати, доки він не створений за допомогою оператора new

        }
    }
}


using System;

namespace CSharpApplication.one_dimensional_array
{
    class MainClass
    {
        static void Main()
        {
            // Створення масиву із 10 елементів типу int.
            // Усі елементи масиву ініціалізуються нулями
            int[] intArray = new int[10];
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write("{0,4}", intArray[i]);
            }
            Console.WriteLine();

            // Створення та ініціалізація
            int[] intArray2 = [1, 2, 3, 4];
            for (int i = 0; i < intArray2.Length; i++)
            {
                Console.Write("{0,4}", intArray2[i]);
            }
            Console.WriteLine();

            // Створення та ініціалізація (вкорочений варіант)
            int[] arr2 = { 0, 3, 7, 17, 25 };
            // Можна оголосити масив без ініціалізації
            int[] arr3 = null;
            // Але його не можна використовувати, доки він не створений за допомогою оператора new
            /*
            arr3[0] = 0; // Помилка компіляції
            arr3 = {0, 3, 7, 17, 25}; // Помилка компіляції
            */
            arr3 = [0, 3, 7, 17, 25];
            arr3[0] = 10;
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write("{0,4}", arr3[i]);
            }
            Console.WriteLine();

            // Створення масиву з 10 елементів типу string. 
            // Усі елементи масиву ініціалізуються null, 
            // оскільки string - посилальний тип
            string[] stringArray = new string[10];
            string[] stringArray2 = ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"];
            for (int i = 0; i < stringArray2.Length; i++)
            {
                Console.WriteLine(stringArray2[i]);
            }
        }
    }
}


using System;

namespace CSharpApplication.methodsOfArray
{
    class MainClass
    {
        static void Main()
        {
            int[] ar = new int[20];
            Random rnd = new();
            Console.WriteLine("Original integer array: ");
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = rnd.Next(-20, 20);
                Console.Write("{0,4}", ar[i]);
            }
            Console.WriteLine();

            int number = 7, position;
            Console.WriteLine("Enter a number to search: ");
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " Let's take the number for search equal to 7");
            }
            position = Array.IndexOf(ar, number); // Пошук першого входження числа до масиву
            if (position >= 0)
                Console.WriteLine("The first occurrence of the entered number was found at position " + position);
            else
                Console.WriteLine("There is no such number in the array");
            Console.WriteLine();

            Console.WriteLine("Enter a number to search: ");
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " Let's take the number for search equal to 7");
            }
            position = Array.LastIndexOf(ar, number); // Пошук останнього входження числа до масиву
            if (position >= 0)
                Console.WriteLine("The last occurrence of the entered number was found at position " + position);
            else
                Console.WriteLine("There is no such number in the array");
            Console.WriteLine();

            Console.WriteLine("Array sorted in ascending order: ");
            Array.Sort(ar); // Сортування за зростанням
            for (int i = 0; i < ar.Length; i++)
            {
                Console.Write("{0,4}", ar[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Enter a number to search: ");
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " Let's take the number for search equal to 7");
            }
            position = Array.BinarySearch(ar, number);
            if (position >= 0)
                Console.WriteLine("The number is located in the array at position " + position);
            else
                Console.WriteLine("There is no such number in the array");
            Console.WriteLine();

            Console.WriteLine("Array sorted in descending order: ");
            Array.Reverse(ar); // Сортування за спаданням
            foreach (int n in ar)
                Console.Write("{0,4}", n); // Змінна n доступна лише для читання
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Original real array: ");
            double[] doubleArr = new double[10];
            for (int i = 0; i < doubleArr.Length; i++)
            {
                doubleArr[i] = rnd.NextDouble() * 100;
                Console.Write("{0:F3}\t", doubleArr[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Copied real array: ");
            double[] doubleArr2 = new double[10];
            Array.Copy(doubleArr, doubleArr2, doubleArr.Length);
            foreach (double n in doubleArr2)
                Console.Write("{0:F3}\t", n); // Змінна n доступна лише для читання
            Console.WriteLine();
            Console.WriteLine();

            Array.Clear(doubleArr, 0, doubleArr.Length); // Обнулювання масиву
            foreach (double n in doubleArr)
                Console.Write("{0,4}", n); // Змінна n доступна лише для читання
            Console.WriteLine();

        }
    }
}


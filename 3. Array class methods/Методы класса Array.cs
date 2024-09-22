using System;

namespace CSharpApplication.methodsOfArray
{
    class MainClass
    {
        static void Main()
        {
            int[] ar = new int[10];
            Random rnd = new();
            Console.WriteLine("Исходный целочисленный массив: ");
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = rnd.Next(-20, 20);
                Console.Write("{0,4}", ar[i]);
            }
            Console.WriteLine();

            int number = 7, position;
            Console.WriteLine("Введите число для поиска: ");
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " Принимаем число для поиска = 7");
            }
            position = Array.IndexOf(ar, number); // поиск первого вхождения числа в массив
            if (position >= 0)
                Console.WriteLine("Первое вхождение введенного числа найдено в позиции " + position);
            else
                Console.WriteLine("Такого числа нет в массиве!");
            Console.WriteLine();

            Console.WriteLine("Введите число для поиска: ");
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " Принимаем число для поиска = 7");
            }
            position = Array.LastIndexOf(ar, number); // поиск последнего вхождения числа в массив
            if (position >= 0)
                Console.WriteLine("Последнее вхождение введенного числа найдено в позиции " + position);
            else
                Console.WriteLine("Такого числа нет в массиве!");
            Console.WriteLine();

            Console.WriteLine("Массив, отсортированный по возрастанию: ");
            Array.Sort(ar); // сортировка по возрастанию
            for (int i = 0; i < ar.Length; i++)
            {
                Console.Write("{0,4}", ar[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Введите число для поиска: ");
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " Принимаем число для поиска = 7");
            }
            position = Array.BinarySearch(ar, number);
            if (position >= 0)
                Console.WriteLine("Искомое число находится в массиве в позиции " + position);
            else
                Console.WriteLine("Такого числа нет в массиве!");
            Console.WriteLine();

            Console.WriteLine("Массив, отсортированный по убыванию: ");
            Array.Reverse(ar); // сортировка по убыванию
            foreach (int n in ar)
                Console.Write("{0,4}", n); // переменная n доступна только для чтения
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Исходный вещественный массив: ");
            double[] doubleArr = new double[10];
            for (int i = 0; i < doubleArr.Length; i++)
            {
                doubleArr[i] = rnd.NextDouble() * 100;
                Console.Write("{0:F3}\t", doubleArr[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Скопированный вещественный массив: ");
            double[] doubleArr2 = new double[10];
            Array.Copy(doubleArr, doubleArr2, doubleArr.Length);
            foreach (double n in doubleArr2)
                Console.Write("{0:F3}\t", n); // переменная n доступна только для чтения
            Console.WriteLine();
            Console.WriteLine();

            Array.Clear(doubleArr, 0, doubleArr.Length); // обнуление массива
            foreach (double n in doubleArr)
                Console.Write("{0,4}", n); // переменная n доступна только для чтения
            Console.WriteLine();

        }
    }
}


using System;
namespace CSharp.AvgOfArray
{
    class Average
    {
        static void Main()
        {
            int count = 10;
            Console.WriteLine("Enter the number of array elements: ");
            try
            {
                count = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " Let's take the number of elements equal to 10.");
            }
            Random r = new();
            int[] a = new int[count];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(1, 20);
                Console.Write("{0,4}", a[i]);
            }

            Console.WriteLine("\nAverage value = {0}", Avg(a));

        }
        public static double Avg(int[] a)
        {
            double average = 0;
            foreach (var i in a)
                average += i;
            return average / a.Length;
        }
    }
}
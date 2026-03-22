using System;
namespace CSharp.String
{
    class MainClass
    {
        static void Main()
        { 
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetWindowSize(120, 30);
            Console.Clear();    
            Console.Title = "The title has changed!";
            string s = "This is a simple line";
            Console.WriteLine(s);
           
            string result = string.Format("Line length: {0}", s.Length);
            Console.WriteLine(result);

            string t = s.Substring(10, 6); // Повертає підрядок із 6 символів, починаючи з 10 позиції
            Console.WriteLine(t);
            Console.WriteLine(s[8]);

            s = s.Replace("i", "I");
            Console.WriteLine(s);

            s = s.Remove(4, 8); // Видаляє 8 символів, починаючи з позиції 4
            Console.WriteLine(s);

            //str[5] = '!'; // Неприпустимо: доступ лише на читання
            char[] ar = { 's', 't', 'r', 'i', 'n', 'g' };

            string s2 = new string(ar);
            Console.WriteLine(s2);
            Console.WriteLine("Line length: " + s2.Length);

            string[] arstr = { " Platform ", " .NET ", " Core " };
            for (int i = 0; i < arstr.Length; i++)
            {
                Console.WriteLine(arstr[i]);
            }
            arstr[0] = " Common ";
            arstr[1] = " Language ";
            arstr[2] = " Runtime ";
            for (int i = 0; i < arstr.Length; i++)
            {
                Console.WriteLine(arstr[i]);
            }

            Console.WriteLine("Enter the first line: ");
            string s3 = Console.ReadLine();
            Console.WriteLine("Enter the second line: ");
            string s4 = Console.ReadLine();
            if (s3.CompareTo(s4) > 0)
                Console.WriteLine(s3 + " more than " + s4);
            else if (s3.CompareTo(s4) < 0)
                Console.WriteLine(s4 + " more than " + s3);
            else
                Console.WriteLine("The lines are equal");

            string text = "To be or not be";
            Console.WriteLine(" Index of first occurrence of a word \"be\" = {0} ", text.IndexOf("be"));
            Console.WriteLine(" Last occurrence index of a word \"be\" = {0} ", text.LastIndexOf("be"));

            Console.WriteLine();
            string words = "This    string will   be split    into an   array of   strings";
            string[] arrayOfString = words.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s5 in arrayOfString)
            {
                Console.WriteLine(s5);
            }
            string res = string.Join(" ", arrayOfString);
            Console.WriteLine(res);

            string str1 = "I'm ";
            string str2 = "learning";
            string str3 = " C#";
            string str4 = str1 + str2 + str3;

            Console.WriteLine("{0} + {1} + {2} = {3}", str1, str2, str3, str4);

            str4 = str4.Replace("learning", "studying");
            Console.WriteLine(str4);

            str4 = str4.Insert(15, " hard!").ToUpper();
            Console.WriteLine(str4);

            if (str4.Contains("hard"))
                Console.WriteLine("I still learning hard :)");
            else
                Console.WriteLine("I am learning C# as much as I can.");
        }
    }
}
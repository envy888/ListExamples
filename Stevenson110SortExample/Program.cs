using System;
using System.Collections.Generic;

namespace Stevenson110SortExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = EnterList();
            Console.WriteLine(ListToString(numbers));
            numbers.Sort();
            Console.WriteLine(ListToString(numbers));
        }

        private static List<int> EnterList()
        {
            List<int> result = new List<int>();
            int input = GetInt();
            while (input != 0)
            {
                result.Add(input);
                input = GetInt();
            }

            return result;
        }

        private static int GetInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        
        private static string ListToString(List<int> numbers)
        {
            string result = string.Empty;
            foreach (int number in numbers)
            {
                result += number.ToString() + " ";
            }

            return result;
        }
        
        
        
    }
}
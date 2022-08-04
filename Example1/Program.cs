using System;
using System.Collections.Generic;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); // список это обобщенная коллекция пронумерованных элементов, список - динамическая структура данных, ее размер может меняться 
            List<int> numbers = new List<int>(); // создание пустого списка 
            numbers.Add(5);
            Console.WriteLine(ListToString(numbers));
            Console.WriteLine(ListToString(RandomList(10)));

            List<int> testlist = RandomList(10);
            Console.WriteLine(ListToString(testlist));
            int a = testlist[2];
            Console.WriteLine(a);
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
        
        private static List<int> RandomList(int length, int min = -1000, int max = 1000)
        {
            Random rng = new Random();
            List<int> result = new List<int>(); 
            for (int i = 0; i < length; i++)
            {
                result.Add(rng.Next(min, max));
            }

            return result;
        }
    }
}
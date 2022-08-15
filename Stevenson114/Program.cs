using System;
using System.Collections.Generic;

namespace Stevenson114
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> test = EnterList();
            Console.WriteLine(ListToString(test));
            
            List<int> positives = SelectPositiveNumbers(test);
            List<int> negatives = SelectNegativeNumbers(test);
            List<int> zeroes = SelectZeroesNumbers(test);
            string result = ListToString(negatives) + ListToString(zeroes) + ListToString(positives);
            
            Console.WriteLine(result);
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
        
       

        private static List<int> EnterList()
        {
            List<int> result = new List<int>();
            
            string enter = Console.ReadLine();
            while (enter != "")
            {
                result.Add(Convert.ToInt32(enter));
                enter = Console.ReadLine();
            }
            
            return result;
        }

        private static List<int> SelectPositiveNumbers(List<int> numbers)
        {   
            List<int> result = new List<int>();
            
            foreach (int number in numbers)
            {
                if (number > 0)
                {
                    result.Add(number);
                }
            }

            return result;
        }

        private static List<int> SelectNegativeNumbers(List<int> numbers)
        {
            List<int> result = new List<int>();

            foreach (int number in numbers)
            {
                if (number < 0)
                {
                    result.Add(number);
                }
            }

            return result;
        }
        
        private static List<int> SelectZeroesNumbers(List<int> numbers)
        {   
            List<int> result = new List<int>();
            
            foreach (int number in numbers)
            {
                if (number == 0)
                {
                    result.Add(number);
                }
            }

            return result;
        }
        
    }
    
}
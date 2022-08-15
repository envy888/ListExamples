using System;
using System.Collections.Generic;

namespace Stevenson113
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = EnterList();
            Console.WriteLine(ListToString(words));
            Console.WriteLine(ListToString(RemoveDuplicates(words)));
            
        }
        
        private static string ListToString(List<string> strings)
        {
            string result = string.Empty;
            foreach (string str in strings)
            {
                result += str + " ";
            }

            return result;
        }
        
        private static List<string> EnterList()
        {
            List<string> result = new List<string>();
            
            string enter = Console.ReadLine();
            while (enter != string.Empty)
            {
                result.Add(enter);
                enter = Console.ReadLine();
            }
            
            return result;
        }

        private static List<string> RemoveDuplicates(List<string> words)
        {
            List<string> uniqueWords = new List<string>();
            
            foreach (string word in words)
            {
                if ( !uniqueWords.Contains(word))
                {
                    uniqueWords.Add(word);
                }
            }

            return uniqueWords;
        }
        
        
        
        
        
        
        
    }
}
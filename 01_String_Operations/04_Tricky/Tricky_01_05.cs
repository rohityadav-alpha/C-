using System;
using System.Collections.Generic;
using System.Text;

namespace _01_String_Operations._04_Tricky
{
    internal class Tricky_01_05
    {
        public static void Run()
        {
            Console.WriteLine("---Q1.Find first non-repeating character in a string");
            string word1 = "rohrioth";
            foreach(char ch in word1)
            {
                int count = 0;
                foreach(char ch1 in word1)
                {
                    if (ch == ch1)
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    Console.WriteLine($"{ch} is the first non reaping character");
                    break;
                }
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using StringOperations;
using System.Security.Cryptography.X509Certificates;
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



            Console.WriteLine("---Q2.Find Weather the string is palindrom or not");
            string word3 = "level";
            string rev = "";
            foreach(char ch in word3)
            {
                rev = ch + rev;
            }
            if (rev == word3)
            {
                Console.WriteLine("the string is palindrom");
            }
            else
            {
                Console.WriteLine("the string is not palindrom");
            }
            Console.WriteLine();



            Console.WriteLine("---Q3.find the largest palindromic substring from the sting");
            string word2 = "babaabaabad";
            static int Expand(string s,int left,int right)
            {
                while (left >= 0 && right < s.Length && s[left] == s[right])
                {
                        left--;
                        right++;
                }
                return right - left - 1;
            }
            int maxlen = 0;
            int start = 0;
            for (int i = 0; i < word2.Length; i++)
            {
                int flen = Expand(word2, i, i);

                int slen = Expand(word2, i, i+1);

                int current = Math.Max(flen, slen);

                if (maxlen < current)
                {
                    maxlen = current;
                    start = i - (current - 1) / 2;
                }
               
            }
            string result=word2.Substring(start, maxlen);
            Console.WriteLine(result);
        }
    }
}

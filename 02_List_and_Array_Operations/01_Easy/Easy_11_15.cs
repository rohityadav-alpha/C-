using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _02_List_and_Array_Operations._01_Easy
{
    internal class Easy_11_15
    {

        public static void Run()
        {
            Console.WriteLine("-- 11. Find the Index of the First Occurrence of an Element");
            int[] numbers = { 1, 2, 3, 4, 5 };
            int t = 4;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == t)
                {
                    Console.WriteLine($"the element {t} is at {i} index");
                }
            }
            Console.WriteLine();

        }
    }
}

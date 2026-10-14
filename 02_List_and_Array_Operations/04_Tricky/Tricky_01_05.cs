using System;
using System.Collections.Generic;
using System.Text;

namespace _02_List_and_Array_Operations._04_Tricky
{
    internal class Tricky_01_05
    {
        public static void Run()
        {
            // Tricky Questions 
            Console.WriteLine("-- Q1.Reverse An Array without using any new array");
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int half = arr1.Length / 2;
            for (int i = 0, j = arr1.Length - 1; i < half; i++, j--)
            {
                int temp=arr1[i];
                arr1[i] = arr1[j];
                arr1[j] = temp;
            }
            Console.WriteLine(string.Join(",", arr1));
            Console.WriteLine();



        }
    }
}

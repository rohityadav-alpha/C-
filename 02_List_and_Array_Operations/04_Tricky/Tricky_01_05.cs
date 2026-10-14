using System;
using System.Collections.Generic;
using System.Security.Cryptography;
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


            Console.WriteLine("-- Q2.Shift Zero at the rigth of the array");
            int[] arr2 = { 1, 0, 6, 0, 3, 0, 0, 6, 3, 4, 0, 5 };
            //towpinter approach
            int x = 0;
            for(int i = 0; i<arr2.Length; i++)
            {
                if(arr2[i] != 0)
                {
                    int temp=arr2[i];
                    arr2[i] = arr2[x];
                    arr2[x] = temp;
                    x++;
                }
            }
            Console.WriteLine(string.Join(",",arr2));
            Console.WriteLine();


            
        }
    }
}

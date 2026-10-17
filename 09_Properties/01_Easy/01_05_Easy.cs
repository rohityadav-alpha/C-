using System;
using System.Collections.Generic;
using System.Text;

namespace _09_Properties._01_Easy
{

    public class Accounts
    {
        private double balance;
        public string name { get; set; } = string.Empty;

        public double diposit { get { return balance; } set { if (value > 0) balance += value; else Console.WriteLine("invalid amount"); } }
        public double widthdraw { get { return balance; }  set { if (value<= balance) balance -= value ; else Console.WriteLine("invalid amount"); } }

        public double getBalance { get { return balance; } } 
    }

    public class Students
    {
        public string name { get; set; } = string.Empty;
        public int age { get; set; } = 0;
    }
    internal class _01_05_Easy
    {
        public static void Run()
        {
            Accounts A = new Accounts();
            A.name = "rohit";
            A.diposit = 1500;
            A.widthdraw = 300;
            Console.WriteLine($"{A.getBalance}");
            Console.WriteLine();
            Students S=new Students();
            S.name = "rohit yadav";
            S.age = 18;
            Console.WriteLine($"{S.name} , {S.age}");
        }
    }
}

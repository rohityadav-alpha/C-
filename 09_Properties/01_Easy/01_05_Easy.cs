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
    internal class _01_05_Easy
    {
        public static void Run()
        {
            Accounts A = new Accounts();
            A.diposit = 1500;
            A.widthdraw = 300;
            Console.WriteLine($"{A.getBalance}");
        }
    }
}

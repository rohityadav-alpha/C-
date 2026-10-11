namespace ListOperations;

public static class Easy_01_04
{
    public static void Run()
    {
        Console.WriteLine(" Module 02: List & Array Operations (Easy 1-4)");

        List<int> list1 = new List<int> { 6, 4, 8, 3, 1, 6 };

        // Q1: Find the Sum of All Elements in a List
        // Python:
        // def Sum(l): sum = 0; for i in l: sum += i; return sum
        Console.WriteLine("--- Q1: Sum of All Elements ---");
        // Approach 1: Manual loop
        static int CalculateSum(List<int> list)
        {
            int sum = 0;
            foreach (int num in list)
            {
                sum += num;
            }
            return sum;
        }
        Console.WriteLine("Approach 1 (Loop Sum): " + CalculateSum(list1));
        // Approach 2: LINQ (like Python sum(list1))
        Console.WriteLine("Approach 2 (LINQ .Sum()): " + list1.Sum());
        Console.WriteLine();


        // Q2: Find the Largest and Smallest Element in a List
        // Python:
        // largest = l[0]; smallest = l[0]
        Console.WriteLine("--- Q2: Largest & Smallest Element ---");
        static void FindLargestSmallest(List<int> list)
        {
            int largest = list[0];
            int smallest = list[0];

            foreach (int num in list)
            {
                if (num > largest)
                    largest = num;
                else if (num < smallest)
                    smallest = num;
            }
            Console.WriteLine($"Largest: {largest}, Smallest: {smallest}");
        }
        FindLargestSmallest(list1);
        Console.WriteLine();


        // Q3: Reverse a List Without Using Built-in Reverse
        // Python:
        // rev = []; for i in range(len(l)-1, -1, -1): rev.append(l[i])
        Console.WriteLine("--- Q3: Reverse List Without Built-in Method ---");
        static List<int> ReverseList(List<int> list)
        {
            List<int> reversed = new List<int>();
            // In C#, list.Count is used instead of len(list)
            for (int i = list.Count - 1; i >= 0; i--)
            {
                reversed.Add(list[i]); // .Add() in C# is equivalent to .append() in Python
            }
            return reversed;
        }
        List<int> revResult = ReverseList(list1);
        Console.WriteLine("Original: [" + string.Join(", ", list1) + "]");
        Console.WriteLine("Reversed: [" + string.Join(", ", revResult) + "]");
        Console.WriteLine();

        
    }
}

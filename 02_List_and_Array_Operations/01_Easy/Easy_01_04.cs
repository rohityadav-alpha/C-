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
  
    }
}

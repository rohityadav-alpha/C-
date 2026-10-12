namespace ListOperations;

public static class Easy_05_10
{
    public static void Run()
    {
        Console.WriteLine(" Module 02: List & Array Operations (Easy 5-10)");

        List<int> numbers = new List<int> { 3, 5, 6, 8, 1, 4, 2, 7, 9, 8, 6, 8 };

        // Q5: Count the Occurrences of a Given Element in a List
        // Python: for e in l: if el == e: n += 1
        Console.WriteLine("--- Q5: Count Occurrences ---");
        static int CountOccurrences(List<int> list, int target)
        {
            int count = 0;
            foreach (int item in list)
            {
                if (item == target)
                    count++;
            }
            return count;
        }
        Console.WriteLine($"Number 8 appears {CountOccurrences(numbers, 8)} times.");
        Console.WriteLine();


        // Q6: Check Whether a List Contains a Given Element
        // Python: if el in l: ... or manual loop
        Console.WriteLine("--- Q6: Check Contains Element ---");
        static bool ContainsElement(List<int> list, int target)
        {
            // Built-in: list.Contains(target)
            foreach (int item in list)
            {
                if (item == target)
                    return true;
            }
            return false;
        }
        int searchNum = 7;
        if (ContainsElement(numbers, searchNum))
            Console.WriteLine($"Yes! The element {searchNum} is present in the list.");
        else
            Console.WriteLine($"No! The element {searchNum} is not present in the list.");
        Console.WriteLine();


        // Q7: Find the Second Largest Element in a List
        Console.WriteLine("--- Q7: Find Second Largest Element ---");
        static int FindSecondLargest(List<int> list)
        {
            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            foreach (int num in list)
            {
                if (num > largest)
                {
                    secondLargest = largest;
                    largest = num;
                }
                else if (num > secondLargest && num != largest)
                {
                    secondLargest = num;
                }
            }
            return secondLargest;
        }
        Console.WriteLine("Second largest number is: " + FindSecondLargest(numbers));
        Console.WriteLine();


        
    }
}

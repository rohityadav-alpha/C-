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


        // Q8: Find Common Elements Between Two Lists
        Console.WriteLine("--- Q8: Common Elements Between Two Lists ---");
        List<int> listA = new List<int> { 1, 3, 5, 7, 9 };
        List<int> listB = new List<int> { 0, 2, 3, 6, 7, 8 };

        static List<int> FindCommonElements(List<int> l1, List<int> l2)
        {
            List<int> common = new List<int>();
            foreach (int a in l1)
            {
                if (l2.Contains(a) && !common.Contains(a))
                {
                    common.Add(a);
                }
            }
            return common;
        }
        List<int> commonElements = FindCommonElements(listA, listB);
        Console.WriteLine("Common Elements: [" + string.Join(", ", commonElements) + "]");
        Console.WriteLine();


        // Q9: Merge Two Lists Without Duplicates
        Console.WriteLine("--- Q9: Merge Two Lists Without Duplicates ---");
        static List<int> MergeWithoutDuplicates(List<int> l1, List<int> l2)
        {
            // Approach: Use HashSet to guarantee uniqueness
            HashSet<int> mergedSet = new HashSet<int>(l1);
            foreach (int item in l2)
            {
                mergedSet.Add(item);
            }
            return mergedSet.ToList();
        }
        List<int> merged = MergeWithoutDuplicates(listA, listB);
        Console.WriteLine("Merged Unique: [" + string.Join(", ", merged) + "]");
        Console.WriteLine();


        // Q10: Separate Different Types of Elements (Python isinstance() vs C# Pattern Matching)
        // Python:
        // if isinstance(l[i], str): str_list.append(l[i])
        // elif isinstance(l[i], int): int_list.append(l[i])
        Console.WriteLine("--- Q10: Separate Different Types (isinstance equivalent) ---");
        // In C#, object is the root type of all types (like Python's any object)
        List<object> mixedList = new List<object> { 1, "b", 7, "c", 5, 4, "r", 7, 4, "c" };

        List<int> intList = new List<int>();
        List<string> strList = new List<string>();

        foreach (object item in mixedList)
        {
            // C# pattern matching 'is' works just like Python's isinstance()!
            if (item is int num)
            {
                intList.Add(num);
            }
            else if (item is string str)
            {
                strList.Add(str);
            }
        }

        Console.WriteLine("Integers: [" + string.Join(", ", intList) + "]");
        Console.WriteLine("Strings:  [" + string.Join(", ", strList) + "]");
        Console.WriteLine();
    }
}

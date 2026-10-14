namespace StringOperations;

public static class Easy_01_04
{
    public static void Run()
    {
        Console.WriteLine(" Module 01: String Operations (Easy 1-4)");


        // Q1: Find the Length of a String Without Using Built-in Length
        // C#: "rohit".Length (Note: Length is a property, not a method, so no ())
        Console.WriteLine("--- Q1: Find String Length ---");
        Console.WriteLine("Built-in Length of 'rohit': " + "rohit".Length);

        // In C#, functions inside functions are called "Local Functions"
        static int CustomLength(string s)
        {
            int count = 0;
            // Python: for i in s:
            // C#: foreach (char c in s) -> in C#, characters in a string are of type 'char' (single quotes)
            foreach (char c in s)
            {
                count++;
            }
            return count;
        }
        Console.WriteLine("Custom CustomLength('rohit'): " + CustomLength("rohit"));
        Console.WriteLine();


        // Q2: Print Every Character of a String
        // Python:
        // def Char(s: str):
        //     for i in s:
        //         print(i)
        Console.WriteLine("--- Q2: Print Every Character ---");
        static void PrintChars(string s)
        {
            foreach (char c in s)
            {
                Console.WriteLine(c);
            }
        }
        Console.WriteLine("Characters of 'roshni':");
        PrintChars("roshni");
        Console.WriteLine();


        // Q3: Reverse a String Using a Loop
        // Python:
        // for i in range(len(s)-1, -1, -1):
        //     rev += s[i]
        // C#:
        // for (int i = s.Length - 1; i >= 0; i--)
        Console.WriteLine("--- Q3: Reverse String Using Loop ---");
        static void Reverse(string s)
        {
            string rev = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                rev += s[i]; // Accessing char by index: s[i] works just like Python!
            }
            // Python: print(f"Reversed: {rev}")
            // C#: Console.WriteLine($"Reversed: {rev}"); (String interpolation uses $)
            Console.WriteLine($"Original: {s} -> Reversed: {rev}");
        }
        Reverse("vikas");
        Console.WriteLine();


        // Q4: Check Whether a String Is a Palindrome
        Console.WriteLine("--- Q4: Check Palindrome ---");
        static void CheckPalindrome(string s)
        {
            string rev = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                rev += s[i];
            }

            // In C#, string comparison with == checks string contents (value equality), just like Python!
            if (rev == s)
            {
                Console.WriteLine($"The string '{s}' IS a palindrome.");
            }
            else
            {
                Console.WriteLine($"The string '{s}' is NOT a palindrome.");
            }
        }
        CheckPalindrome("boob");
        CheckPalindrome("rohit");
        Console.WriteLine();

    }
}

namespace StringOperations;

public static class Easy_05_10
{
    public static void Run()
    {
        Console.WriteLine(" Module 01: String Operations (Easy 5-10)");
        // Q5: Count Vowels and Consonants
        // Python: if ch in "aeiou": v += 1
        // C#: if ("aeiouAEIOU".Contains(ch))
        Console.WriteLine("--- Q5: Count Vowels & Consonants ---");
        static void CountVowelsConsonants(string w)
        {
            int vowels = 0;
            int consonants = 0;
            string vowelSet = "aeiouAEIOU";

            foreach (char ch in w)
            {
                if (char.IsLetter(ch)) // Ensure it is an alphabet character
                {
                    if (vowelSet.Contains(ch))
                        vowels++;
                    else
                        consonants++;
                }
            }
            Console.WriteLine($"Text: '{w}' -> Vowels: {vowels}, Consonants: {consonants}");
        }
        CountVowelsConsonants("Rohit Kumar Yadav");
        Console.WriteLine();


        // Q6: Count Uppercase, Lowercase, Digits, and Special Characters
        // Python: ch.isupper(), ch.islower(), ch.isdigit()
        // C#: char.IsUpper(ch), char.IsLower(ch), char.IsDigit(ch)
        Console.WriteLine("--- Q6: Count Character Types ---");
        static void CountCharacterTypes(string s)
        {
            int upper = 0, lower = 0, digits = 0, special = 0;

            foreach (char ch in s)
            {
                if (char.IsUpper(ch))
                    upper++;
                else if (char.IsLower(ch))
                    lower++;
                else if (char.IsDigit(ch))
                    digits++;
                else
                    special++;
            }

            Console.WriteLine($"Input: {s}");
            Console.WriteLine($"Uppercase: {upper}\nLowercase: {lower}\nDigits: {digits}\nSpecial: {special}");
        }
        CountCharacterTypes("Rohit@123_CSharp#2026");
        Console.WriteLine();


        // Q7: Count Occurrences of a Given Character
        // Python: for ch in word: if ch == char: n += 1
        // C#: foreach (char ch in word) if (ch == target) count++;
        Console.WriteLine("--- Q7: Count Occurrences of Character ---");
        static void CountCharOccurrences(string word, char target)
        {
            int count = 0;
            foreach (char ch in word)
            {
                if (ch == target)
                    count++;
            }
            Console.WriteLine($"Character '{target}' appears {count} times in '{word}'");
        }
        CountCharOccurrences("programming in csharp", 'r');
        Console.WriteLine();


        // Q8: Remove All Spaces from a String
        // Python: s.replace(" ", "")
        // C#: s.Replace(" ", "") (Note: PascalCase method name!)
        Console.WriteLine("--- Q8: Remove Spaces ---");
        string name = "rohit kumar  yadav";
        // Solution 1: Built-in Replace
        string noSpace1 = name.Replace(" ", "");
        Console.WriteLine($"Solution 1 (Replace): '{noSpace1}'");

        // Solution 2: Without Replace (Manual loop)
        string noSpace2 = "";
        foreach (char ch in name)
        {
            if (ch != ' ')
                noSpace2 += ch;
        }
        Console.WriteLine($"Solution 2 (Loop):    '{noSpace2}'");
        Console.WriteLine();


        // Q9: Swap First and Last Character of a String
        // Python: s[-1] + s[1:-1] + s[0]
        // C#: Modern C# supports Python-like slicing with ^ and .. !
        //     s[^1] means last char (like s[-1])
        //     s[1..^1] means slice from index 1 to second-to-last (like s[1:-1])
        Console.WriteLine("--- Q9: Swap First and Last Character ---");
        static string SwapFirstLast(string s)
        {
            if (s.Length <= 1) return s;

            // Python slicing equivalent in modern C#!
            return s[^1] + s[1..^1] + s[0];
        }
        Console.WriteLine($"Original: 'hello' -> Swapped: '{SwapFirstLast("hello")}'");
        Console.WriteLine($"Original: 'python' -> Swapped: '{SwapFirstLast("python")}'");
        Console.WriteLine();


        // Q10: Capitalize First Letter of Each Word Without title()
        // Python: [w.capitalize() for w in s.split()]
        // C#: s.Split(' ') then capitalize first char of each word
        Console.WriteLine("--- Q10: Capitalize First Letter of Each Word ---");
        static string CapitalizeWords(string sentence)
        {
            string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                string w = words[i];
                if (w.Length > 0)
                {
                    // char.ToUpper on first character + remaining substring
                    words[i] = char.ToUpper(w[0]) + w.Substring(1).ToLower();
                }
            }
            return string.Join(" ", words);
        }
        string letter = "dear sir rohit thanks you";
        Console.WriteLine($"Original: '{letter}'");
        Console.WriteLine($"Capitalized: '{CapitalizeWords(letter)}'");
        Console.WriteLine();
    }
}

# 🚀 Python to C# Practice Roadmap & Master Guide

Welcome Rohit! This repository is structured specifically to transition your **Python** knowledge to **C# (.NET 10)** smoothly by comparing the exact concepts and algorithms you wrote in `D:\LEARN_PYTHON\Practice`.

---

## 🧭 Python vs C# Mental Model (Quick Cheat Sheet)

| Concept | Python | C# (.NET 10) | Explanation |
| :--- | :--- | :--- | :--- |
| **Typing** | Dynamic: `x = 10` | Static: `int x = 10;` or `var x = 10;` | C# checks types at compile-time. |
| **Blocks** | Indentation (`4 spaces`) | Braces `{ ... }` + Semicolons `;` | Statements end with `;` in C#. |
| **Printing** | `print(f"Hello {name}")` | `Console.WriteLine($"Hello {name}");` | String interpolation uses `$"..."`. |
| **Input** | `name = input("Enter: ")` | `Console.Write("Enter: "); string name = Console.ReadLine();` | Always returns `string?`. |
| **Booleans** | `True`, `False` | `true`, `false` | Always lowercase in C#. |
| **Null/None** | `None` | `null` | Absence of value. |
| **Length** | `len(x)` | `s.Length` (string/array) or `list.Count` (collections) | Property, not a function (no `()`). |
| **Characters** | Single or double quotes: `"a"` or `'a'` | Double quotes for `string`, single quotes strictly for `char` (`'a'`). | `char` is an explicit type in C#. |
| **List** | `[1, 2, 3]` | `List<int> list = new() { 1, 2, 3 };` | Dynamic size, strongly typed. |
| **Fixed Array**| `array('i', [1, 2])` | `int[] arr = { 1, 2, 3 };` | Fixed size in memory. |
| **Dictionary**| `{"a": 1, "b": 2}` | `Dictionary<string, int> dict = new();` | Key-Value collection. |
| **Set** | `{1, 2, 3}` | `HashSet<int> set = new() { 1, 2, 3 };` | Unique elements only. |
| **Tuple** | `(1, "rohit")` | `(int, string) t = (1, "rohit");` | Modern C# ValueTuples. |
| **Membership**| `if x in my_list:` | `if (my_list.Contains(x))` | `.Contains()` method. |
| **Reverse Loop**| `for i in range(len(s)-1, -1, -1):` | `for (int i = s.Length - 1; i >= 0; i--)` | Exact index loop. |
| **Foreach** | `for item in items:` | `foreach (var item in items)` | Reads each element directly. |
| **Type Check**| `if isinstance(x, int):` | `if (x is int num)` | Pattern matching with `is`. |
| **Comprehension**| `[x*2 for x in nums if x > 2]`| `nums.Where(x => x > 2).Select(x => x * 2).ToList()` | LINQ (Language Integrated Query). |

---

## 📁 Repository Structure (Mirroring Your Python Practice)

```text
D:\LEARN_C#\
│
├── LearnCSharp.sln               # Master Solution linking all projects
│
├── 01_String_Operations\         # Mirroring 01_string_operation_que
│   ├── 01_Easy\
│   │   ├── Easy_01_04.cs         # Q1-Q4: Length, Char print, Reverse, Palindrome
│   │   └── Easy_05_10.cs         # Q5-Q10: Vowels, Counts, Space remove, Swap, Title
│   └── Program.cs
│
├── 02_List_and_Array_Operations\ # Mirroring 02_List_operations
│   ├── 01_Easy\
│   │   ├── Easy_01_04.cs         # Q1-Q4: Sum, Min/Max, Reverse, Remove Duplicates
│   │   └── Easy_05_10.cs         # Q5-Q10: Occurrences, Search, 2nd Largest, Common, Merge, Type Sep
│   └── Program.cs
│
├── 03_Dictionary_Operations\     # Mirroring 03_Dictionary_operation_question
│   └── Program.cs
│
├── 04_HashSet_Operations\        # Mirroring 04_sets_operations_que
│   └── Program.cs
│
├── 05_Tuple_Operations\          # Mirroring 05_Tuples_operations_que
│   └── Program.cs
│
├── 06_Loops_and_Patterns\        # Mirroring 06_loops_practice (6 themes)
│   └── Program.cs
│
├── 07_Array_Operations\          # Mirroring 07_Array_operation_que
│   └── Program.cs
│
└── 08_OOP_and_LINQ\              # Python Modules & Comprehensions -> C# Classes & LINQ
    └── Program.cs
```

---

## ⚡ How to Run Any Practice Module

Open PowerShell or your terminal in `D:\LEARN_C#` and run:

```powershell
# Run Module 01 (Strings)
dotnet run --project 01_String_Operations

# Run Module 02 (Lists & Arrays)
dotnet run --project 02_List_and_Array_Operations

# Run any other module
dotnet run --project 03_Dictionary_Operations
```

---

## 🎯 8-Step Practice Curriculum

### 🔹 Module 1: String Operations
- **Easy**: Length without `.Length`, Reverse string, Palindrome check, Count vowels/consonants, Character count (Upper/Lower/Digits/Special), Swap first & last char (`s[^1] + s[1..^1] + s[0]`), Capitalize words.
- **Medium**: Anagram check (sorting vs frequency array), Substring search without `.IndexOf()`, Remove duplicate characters from string, Longest word in sentence.
- **Tricky/Hard**: Longest common prefix, String compression (`"a3b2"`), Valid parentheses with string.

### 🔹 Module 2: Lists & Collections (`List<T>`)
- **Easy**: Sum of elements, Min/Max, Reverse list without `.Reverse()`, Remove duplicates with and without `HashSet`, Count occurrences, Common elements between two lists, Merge lists.
- **Medium**: Rotate list by K positions, Find missing number (1 to N), Pair sum problem (two numbers that sum to target), Move all zeros to end.
- **Tricky/Hard**: Flatten nested list, Subarray with maximum sum (Kadane's algorithm), Rearrange positive and negative numbers.

### 🔹 Module 3: Dictionary Operations (`Dictionary<TKey, TValue>`)
- Frequency counter for characters/words, Invert dictionary (swap keys and values), Merge two dictionaries, Group students by grade, Word count from a paragraph.

### 🔹 Module 4: Sets (`HashSet<T>`)
- Union, Intersection, Difference between sets, Check subset/superset, Find first duplicate in a collection, Symmetric difference.

### 🔹 Module 5: Tuples & ValueTuples
- Returning multiple values from a method `(bool success, int value)`, Deconstruction `var (name, age) = person;`, Tuple pattern matching in `switch`.

### 🔹 Module 6: Loops & Pattern Printing
- Right-angle triangle, Inverted triangle, Pyramid, Hollow square, Pascal's triangle, Floyd's triangle, Multiplication tables, Prime number generator, Fibonacci sequence.

### 🔹 Module 7: Array Operations (1D, 2D Matrices)
- Matrix addition, Matrix transpose, Diagonal sum, Search in 2D sorted matrix, Spiral matrix traversal.

### 🔹 Module 8: OOP & LINQ (C#'s Superpowers)
- Classes, Fields, Properties (`get; set;`), Constructors, Inheritance (`:`), Interfaces (`interface`).
- LINQ: `.Where()` (filter), `.Select()` (map), `.OrderBy()`, `.GroupBy()`, `.Any()`, `.All()`, `.Aggregate()` (reduce).

 
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        string str1 = "Hello";
        string str2 = "World";
        //string result = str1 + ", " + str2 + "!"; */

        /*string name = "Alice";
        int age = 30;
        string result = $"Name: {name}, Age: {age}";*/
        string str = "   sumangurung  ";
        char firstChar = str[0]; // 'H'
        int length = str.Length;
        string substr = str.Substring(6, 5); // urung
        int index = str.IndexOf('g'); // 5
        bool contains = str.Contains("World"); // false
        string replaced = str.Replace("urung", "Universe"); // "sumanguniverse"
        string upper = str.ToUpper(); // "SUMANGURUNG"
        string lower = str.ToLower(); // "sumangurung"
        string trimmed = str.Trim();
        bool isEqual = str1 == str2; // true or false
        bool isEqualIgnoreCase = str1.Equals(str2, StringComparison.OrdinalIgnoreCase);
        int comparison = string.Compare(str1, str2); // -1, 0, or 1
        string sentence = "This is a test.";
        string[] words = sentence.Split(' '); // {"This", "is", "a", "test."}
        string joined = string.Join(", ", words); // "This, is, a, test."




        Console.WriteLine(str[0]);
        Console.WriteLine(length);
        Console.WriteLine(substr);//"urung"
        Console.WriteLine(index);
        Console.WriteLine(contains); 
        Console.WriteLine(replaced);
        Console.WriteLine(upper);
        Console.WriteLine(lower);
        Console.WriteLine(trimmed);  
        Console.WriteLine(joined);


        Console.ReadLine();
    }
}

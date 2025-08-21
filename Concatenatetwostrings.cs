using System;

class Program
{
    static void Main()
    {
        // Input: First string
        Console.Write("Enter the first string: ");
        string str1 = Console.ReadLine();

        // Input: Second string
        Console.Write("Enter the second string: ");
        string str2 = Console.ReadLine();

        // Concatenate strings
        string concatenated = str1 + str2;
        Console.WriteLine($"\nConcatenated String: {concatenated}");

        // Input: Substring to find
        Console.Write("\nEnter the substring to find: ");
        string toFind = Console.ReadLine();

        // Check if substring exists
        if (concatenated.Contains(toFind))
        {
            Console.WriteLine($"Substring '{toFind}' found in the concatenated string.");
        }
        else
        {
            Console.WriteLine($"Substring '{toFind}' not found in the concatenated string.");
        }

        // Input: Substring to replace with
        Console.Write("Enter the new substring to replace with: ");
        string toReplace = Console.ReadLine();

        // Replace substring
        string replaced = concatenated.Replace(toFind, toReplace);
        Console.WriteLine($"\nString after replacement: {replaced}");

        Console.ReadLine();
    }
}

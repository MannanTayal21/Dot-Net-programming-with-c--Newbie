using System;

class Program
{
    static void Main()
    {
        // Prompt user to enter two integers
        Console.Write("Enter the first number (var1): ");
        int var1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number (var2): ");
        int var2 = Convert.ToInt32(Console.ReadLine());

        // Check if exactly one is greater than 10 using XOR
        bool onlyOneGreaterThan10 = (var1 > 10) ^ (var2 > 10);

        // Display result
        if (onlyOneGreaterThan10)
        {
            Console.WriteLine("Exactly one of the numbers is greater than 10.");
        }
        else
        {
            Console.WriteLine("Either both numbers are greater than 10 or neither is.");
        }

        Console.ReadLine();
    }
}

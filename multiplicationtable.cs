using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        // Try to parse the input to an integer
        if (int.TryParse(input, out int number))
        {
            Console.WriteLine($"\nMultiplication Table for {number}:");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }

        Console.ReadLine();
    }
}

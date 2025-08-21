using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter four numbers:");

        // Read and parse 4 numbers
        Console.Write("Enter number 1: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter number 2: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter number 3: ");
        double num3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter number 4: ");
        double num4 = Convert.ToDouble(Console.ReadLine());

        // Calculate average and product
        double average = (num1 + num2 + num3 + num4) / 4;
        double product = num1 * num2 * num3 * num4;

        // Print the results
        Console.WriteLine($"\nAverage: {average}");
        Console.WriteLine($"Product: {product}");
        Console.ReadLine();
    }
}

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        double num = Convert.ToDouble(Console.ReadLine());

        double x = num;
        double root;

        // Basic approximation loop (similar to long division idea)
        for (int i = 0; i < 10; i++)
        {
            x = (x + num / x) / 2;
        }

        root = x;

        Console.WriteLine("\nSquare root = " + root.ToString("0.00"));

        Console.WriteLine("\nThis program was written and executed by Mannan Tayal (0231BCA047)");
    }
}
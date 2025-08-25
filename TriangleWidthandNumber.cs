using System;

class Program
{
    static void Main()
    {
        // Get the number to display
        Console.Write("Enter a number to display: ");
        string number = Console.ReadLine();

        // Get the width of the triangle (number of lines)
        Console.Write("Enter the width of the triangle: ");
        int width = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nGenerated Triangle:\n");

        // Loop to print triangle
        for (int i = 1; i <= width; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nThis program was written and executed by Mannan Tayal (0231BCA047)");
        Console.ReadLine();
    }
}

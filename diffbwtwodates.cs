using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first date (yyyy-mm-dd): ");
        DateTime date1 = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter second date (yyyy-mm-dd): ");
        DateTime date2 = DateTime.Parse(Console.ReadLine());

        TimeSpan diff = date2 - date1;

        Console.WriteLine("Difference: " + Math.Abs(diff.Days) + " days");

        Console.WriteLine("This program is written and executed by Mannan Tayal (0231BCA047)");
    }
}

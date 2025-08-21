using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
            Console.WriteLine(year + " is a leap year.");
        else
            Console.WriteLine(year + " is not a leap year.");

        Console.WriteLine("This program is written and executed by Mannan Tayal (0231BCA047)");
    }
}

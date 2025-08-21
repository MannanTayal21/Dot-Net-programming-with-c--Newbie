using System;

class Program
{
    static void Main()
    {
        Console.Write("Class start time (hh:mm): ");
        DateTime start = DateTime.Parse(Console.ReadLine());

        Console.Write("Your entry time (hh:mm): ");
        DateTime entry = DateTime.Parse(Console.ReadLine());

        Console.Write("Is it rainy? (yes/no): ");
        string rain = Console.ReadLine().ToLower();

        int allowed = (rain == "yes") ? 25 : 15;

        TimeSpan late = entry - start;

        if (late.TotalMinutes <= allowed && late.TotalMinutes >= 0)
            Console.WriteLine("\nYou are on time. You may Enter the Class");
        else if (late.TotalMinutes < 0)
            Console.WriteLine("\nYou are early. You may Enter the class, Nerd!");
        else
            Console.WriteLine("\nYou are late. You may not Enter the class, Better Luck Next Time!");

        Console.WriteLine("\nThis program was written and executed by Mannan Tayal (0231BCA047)");
    }
}
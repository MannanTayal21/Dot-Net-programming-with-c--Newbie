using System;

class Program
{
    static void Main()
    {
        DateTime d = DateTime.Now;

        Console.WriteLine(d.ToString("d"));
        Console.WriteLine(d.ToString("D"));
        Console.WriteLine(d.ToString("dd-MM-yyyy"));

        Console.WriteLine("This program is written and executed by Mannan Tayal (0231BCA047)");
        Console.ReadLine();
    }
}

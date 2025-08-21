using System;

class Program
{
    static void Main()
    {
        string a = "Hello", b = " World";
        string c = a + b;

        Console.WriteLine(c);
        Console.WriteLine(c.Contains("World") ? "Found" : "Not Found");
        Console.WriteLine(c.Replace("World", "C#"));

        Console.WriteLine("This program is written and executed by Mannan Tayal (0231BCA047)");
    }
}

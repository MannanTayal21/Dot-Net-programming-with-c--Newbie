using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a Number:");
        int n = Convert.ToInt32(Console.ReadLine()), r = 0, t = n;

        while (n > 0)
        {
            r = r * 10 + n % 10;
            n /= 10;
        }

        Console.WriteLine(r == t ? "Palindrome" : "Not Palindrome");
        Console.WriteLine("This program is written and executed by Mannan Tayal (0231BCA047)");
    }
}

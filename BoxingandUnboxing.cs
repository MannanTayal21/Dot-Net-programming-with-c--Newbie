using System;

class Program
{
    static void Main()
    {
        int a = 10;
        object box = a;        // Boxing

        int b = (int)box;      // Unboxing

        Console.WriteLine("Boxed value: " + box);
        Console.WriteLine("Unboxed value: " + b);

        Console.WriteLine("This program is written and executed by Mannan Tayal (0231BCA047)");
    }
}

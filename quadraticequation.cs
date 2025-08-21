using System;

class Program
{
    static void Main()
    {
        double a, b, c, d, r1, r2;

        Console.Write("Enter a: ");
        a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter b: ");
        b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter c: ");
        c = Convert.ToDouble(Console.ReadLine());

        d = b * b - 4 * a * c;

        if (d > 0)
        {
            r1 = (-b + Math.Sqrt(d)) / (2 * a);
            r2 = (-b - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("Roots are real and different");
            Console.WriteLine("Root 1 = " + r1);
            Console.WriteLine("Root 2 = " + r2);
        }
        else if (d == 0)
        {
            r1 = -b / (2 * a);
            Console.WriteLine("Roots are real and equal");
            Console.WriteLine("Root = " + r1);
        }
        else
        {
            Console.WriteLine("Roots are imaginary");
        }

        Console.WriteLine("This program is written and executed by Mannan Tayal (0231BCA047)");
    }
}

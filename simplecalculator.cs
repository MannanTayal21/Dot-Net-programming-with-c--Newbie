using System;

class Program
{
    static void Main()
    {
        double a, b;
        char op;

        Console.Write("Enter first number: ");
        a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter operator (+, -, *, /): ");
        op = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter second number: ");
        b = Convert.ToDouble(Console.ReadLine());

        switch (op)
        {
            case '+': Console.WriteLine("Result = " + (a + b)); break;
            case '-': Console.WriteLine("Result = " + (a - b)); break;
            case '*': Console.WriteLine("Result = " + (a * b)); break;
            case '/': Console.WriteLine(b != 0 ? "Result = " + (a / b) : "Cannot divide by zero"); break;
            default: Console.WriteLine("Invalid operator"); break;
        }

        Console.WriteLine("This program is written and executed by Mannan Tayal (0231BCA047)");
    }
}

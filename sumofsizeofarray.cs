using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the size of the array: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];
        int sum = 0;

        Console.WriteLine("Enter the elements:");

        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
            sum += arr[i];
        }

        Console.WriteLine("\nSum of all elements = " + sum);

        Console.WriteLine("\nThis program was written and executed by Mannan Tayal (0231BCA047)");
    }
}
using System;

class Program
{
    static void Main()
    {
        int[][] arr = {
            new int[] {1, 2, 3},
            new int[] {4, 5},
            new int[] {6, 7, 8, 9}
        };

        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
            for (int j = 0; j < arr[i].Length; j++)
                sum += arr[i][j];

        Console.WriteLine("Sum = " + sum);
        Console.WriteLine("This program is written and executed by Mannan Tayal (0231BCA047)");
    }
}

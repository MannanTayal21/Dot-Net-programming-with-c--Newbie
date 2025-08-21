using System;

class Program
{
    static void Main()
    {
        int[,] A = { { 1, 2 }, { 3, 4 } };
        int[,] B = { { 5, 6 }, { 7, 8 } };
        int[,] C = new int[2, 2];

        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 2; j++)
                C[i, j] = A[i, 0] * B[0, j] + A[i, 1] * B[1, j];

        Console.WriteLine("Result:");
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine(C[i, 0] + " " + C[i, 1]);
        }

        Console.WriteLine("This program is written and executed by Mannan Tayal (0231BCA047)");
    }
}

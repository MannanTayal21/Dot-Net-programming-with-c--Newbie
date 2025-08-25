using System;

class Program
{
    // Function to create the schedule
    static string[] SetSchedule()
    {
        string[] schedule = new string[15];

        schedule[0] = "Monday:";
        schedule[1] = " 9-10   => C#";
        schedule[2] = "10-11   => Python";

        schedule[3] = "Tuesday:";
        schedule[4] = " 9-10   => Lab on C#";
        schedule[5] = "10-11   => Lab on Python";
        schedule[6] = "11-12   => Python";

        schedule[7] = "Wednesday:";
        schedule[8] = " 9-10   => Aptitude";
        schedule[9] = "10-11   => C#";

        schedule[10] = "Thursday:";
        schedule[11] = " 9-10   => Entrepreneur";
        schedule[12] = "10-11   => Python";

        schedule[13] = "Friday:";
        schedule[14] = " 9-10   => Securities";

        return schedule;
    }

    // Function to print the schedule
    static void GetSchedule(string[] schedule)
    {
        Console.WriteLine("\n--- Weekly Class Schedule ---\n");

        foreach (string line in schedule)
        {
            Console.WriteLine(line);
        }
    }

    static void Main()
    {
        string[] weekSchedule = SetSchedule();
        GetSchedule(weekSchedule);

        Console.WriteLine("\nThis program was written and executed by Mannan Tayal (0231BCA047)");
    }
}
using System;

class Program
{
    // Define a structure to hold student information
    struct Student
    {
        public int StudentId;
        public string StudentName;
        public string CourseName;
        public DateTime DateOfBirth;
    }

    static void Main()
    {
        Console.Write("Enter the number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        // Declare an array of Student structures
        Student[] students = new Student[numberOfStudents];

        // Input student data
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine($"\nEnter details for Student #{i + 1}");

            Console.Write("Student ID: ");
            students[i].StudentId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Student Name: ");
            students[i].StudentName = Console.ReadLine();

            Console.Write("Course Name: ");
            students[i].CourseName = Console.ReadLine();

            Console.Write("Date of Birth (yyyy-mm-dd): ");
            students[i].DateOfBirth = DateTime.Parse(Console.ReadLine());
        }

        // Display student data
        Console.WriteLine("\n=== Student Information ===");
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine($"\nStudent #{i + 1}:");
            Console.WriteLine($"ID         : {students[i].StudentId}");
            Console.WriteLine($"Name       : {students[i].StudentName}");
            Console.WriteLine($"Course     : {students[i].CourseName}");
            Console.WriteLine($"Birth Date : {students[i].DateOfBirth.ToString("yyyy-MM-dd")}");
        }

        Console.ReadLine();
    }
}

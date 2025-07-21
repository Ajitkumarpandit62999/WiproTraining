using System;

class Programe
{
    static void Main()
    {

        string[] studentNames = new string[5];
        int[][] studentMarks = new int[5][];

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Enter the name of student {i + 1}:");
            studentNames[i] = Console.ReadLine();

            Console.WriteLine($"Enter the number of subject marks {studentNames[i]}");
            int numMarks = int.Parse(Console.ReadLine());

            studentMarks[i] = new int[numMarks];

            for (int j = 0; j < numMarks; j++)
            {
                Console.Write($"Enter mark {j + 1} for {studentNames[i]}: ");
                studentMarks[i][j] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(); // Blank line for spacing
        }

        // Display all students and their marks
        Console.WriteLine("Student Details:\n");

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Student: {studentNames[i]}");
            Console.Write("Marks: ");
            foreach (int mark in studentMarks[i])
            {
                Console.Write(mark + " ");
            }
            Console.WriteLine("\n");
        }
    }
}

        
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
    public class StudentGrades
    {
        

        public void Run3()
        { 
            

            // Get input from user for number of students
            Console.WriteLine("Enter the number of students:");
            int numStudents = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[numStudents];

            // Initialize arrays to store student names and scores
            string[] studentNames = new string[numStudents];

            int[] studentScores = new int[numStudents];

            // Get input from user for each student's name and score
            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine("Enter the name of student #" + (i + 1) + ":");
                studentNames[i] = Console.ReadLine();

                Console.WriteLine("Enter the MARKS of student #" + (i + 1) + ":");

                studentScores[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Calculate grade for each student based on their score
            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine("Grade for " + studentNames[i] + " is");
                if (studentScores[i] >= 70 && studentScores[i] <= 100)
                {
                    Console.WriteLine("A and obtained MARKS " + studentScores[i]);
                    Console.WriteLine();

                }
                else if (studentScores[i] >= 60 && studentScores[i] <= 69)
                {
                    Console.WriteLine("B and obtained MARKS " + studentScores[i]);
                    Console.WriteLine();
                }
                else if (studentScores[i] >= 50 && studentScores[i] <= 59)
                {
                    Console.WriteLine("C and obtained MARKS " + studentScores[i]);
                    Console.WriteLine();
                }
                else if (studentScores[i] >= 40 && studentScores[i] <= 49)
                {
                    Console.WriteLine("D and obtained MARKS " + studentScores[i]);
                    Console.WriteLine();
                }
                else if (studentScores[i] == 0 && studentScores[i] <= 39)
                {
                    Console.WriteLine("F and obtained MARKS " + studentScores[i]);
                    Console.WriteLine();
                }
            }

        




    

    }
}

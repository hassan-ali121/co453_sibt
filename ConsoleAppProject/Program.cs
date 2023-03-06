using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Derek Peacock 05/02/2022
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2022-2023! ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();


            Console.WriteLine(" Select any of the number : ");
            Console.WriteLine("1. APP 01");
            Console.WriteLine("2. APP 02");

            Console.WriteLine();
            Console.WriteLine("Please Enter any number of App you want to open ");
            string choice = Console.ReadLine();


            if (choice == "1") {
                Console.ForegroundColor = ConsoleColor.Green;
                DistanceConverter converter = new DistanceConverter();
                converter.Run();
                
            }
            if (choice == "2")
            {

                BMI bmi = new BMI();
                bmi.Run1();
            }

        }
    }
}

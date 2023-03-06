using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Sibt version 0.1
    /// </author>
    public class DistanceConverter
    {
        public double miles;
        private double feet;
        private double meter;

        public void Run()
        {
            Console.WriteLine(" Select any of the number : ");
            Console.WriteLine("1. Miles");
            Console.WriteLine("2. feets");
            Console.WriteLine("3. Meters");

            Console.WriteLine("Please Enter any number");
            string choice = Console.ReadLine();


            if (choice == "1")
            {

                //miles to feets
                Console.WriteLine("Please Enter the number of miles");

                double miles = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("The number of miles is " + miles);


                Console.WriteLine("please select which unit you want to" +
                    "convert this value ");

                Console.WriteLine("1. feets");
                Console.WriteLine("2. Meters");
                Console.WriteLine();
                Console.WriteLine("Pleae enter the number :");
                string choice1 = Console.ReadLine();

                if (choice1 == "1")
                {
                    const int Miles_to_Feet = 5200;
                    double feet = miles * Miles_to_Feet;

                    Console.WriteLine(miles + " miles is " + feet + " feet");
                    Console.WriteLine("\n");
                }
                else if (choice1 == "2")
                {
                    double Miles_to_Meters = 1609.34;
                    double meters = miles * Miles_to_Meters;

                    Console.WriteLine(miles + "miles is" + meters + " meters.");

                }
                else
                {
                    Console.WriteLine("You put the wrong selectioin");
                }
            }

            else if (choice == "2")
            {
                //feet to miles
                Console.WriteLine("\n");
                Console.WriteLine("Please Enter the number of feet");
                double feet = Convert.ToDouble(Console.ReadLine());



                Console.WriteLine("Which unit you wanna convert");
                Console.WriteLine("1. Miles");
                Console.WriteLine("2. Meters");

                string choice3 = Console.ReadLine();

                if (choice3 == "1")
                {

                    Console.WriteLine("The number of feet is " + feet);


                    const double Feet_to_Miles = 0.00019;
                    double miles = feet * Feet_to_Miles;

                    Console.WriteLine(miles + " miles is " + feet + " feet");
                }

                else if (choice3 == "2")
                {


                    double feet_to_meter = 0.3048;
                    double meters = feet_to_meter * feet;
                    Console.WriteLine(feet + "Feet is " + meters + " meters ");
                }
            }
            else if (choice == "3")
            {
                //miles to meters
                Console.WriteLine("\n");
                Console.WriteLine("please enter number of feets");
                double meters = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("please select which unit you want to" +
                   "convert this value ");

                Console.WriteLine("1. miles");
                Console.WriteLine("2. feets");



                string choice4 = Console.ReadLine();

                if (choice4 == "1")
                {
                    double meters_to_miles = 0.000621371 * meters;

                    Console.WriteLine(meters + " meters is " + meters_to_miles + " miles");


                }
                else if (choice4 == "2")
                {
                    double meters_to_feet = meters * 3.28084;
                    Console.WriteLine(meters + " meters is " + meters_to_feet + " feets");
                }


            }

            else
            {
                Console.WriteLine("You put invalid value");
            }


        }
    }
}

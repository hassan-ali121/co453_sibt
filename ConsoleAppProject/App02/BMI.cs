using System;
namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    public class BMI
    {


        public double feet;

        public void Run1(){
            Console.WriteLine("========BMI CALCULATOR========");

            Console.WriteLine(" Select any of the number : ");
            Console.WriteLine("1. Metrics form");
            Console.WriteLine("2. Imperial form");
           

            Console.WriteLine("Please Enter any number");
            string choice = Console.ReadLine();


            if (choice == "1")
            {

                Console.WriteLine("ENTER THE WEIGHT IN KG");
                double weight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the Height IN METERS");
                double height = Convert.ToDouble(Console.ReadLine());

                double BMI = weight / (height * height);
                Console.WriteLine("THE BMI IS : " + BMI);

                if (BMI < 18.50)
                {
                    Console.WriteLine("THE PERSON IS UNDERWEIGHT");
                }
                else if (BMI >= 18.5 && BMI <= 24.9)
                {
                    Console.WriteLine("THE PERSON IS OVERWEIGHT");
                }
                else if (BMI >= 25 && BMI <= 29.9)
                {
                    Console.WriteLine("THE PERSON IS OVERWEIGHT");
                }
                else if (BMI >= 30 && BMI <= 34.9)
                {
                    Console.WriteLine("THE PERSON IS OBESE 1 CLASS");

                }
                else if (BMI >= 35 && BMI <= 39.9)
                {
                    Console.WriteLine("THE PERSON IS OBESE 2 CLASS");

                }
                else if (BMI >= 40.0)
                {
                    Console.WriteLine("THE PERSON IS OBESE 3 CLASS");
                }
            }

            else if (choice == "2")
            {


                Console.WriteLine("ENTER THE WEIGHT IN POUNDS");
                double weightInPound = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the Height IN INCHES");
                double heightInFeet = Convert.ToDouble(Console.ReadLine());
                double BMIlbs = (weightInPound * 703) / (heightInFeet * heightInFeet);
                Console.WriteLine("the bhi in imperial calculation is :" + BMIlbs);

                if (BMIlbs < 18.50)
                {
                    Console.WriteLine("THE PERSON IS UNDERWEIGHT");
                }
                else if (BMIlbs >= 18.5 && BMIlbs <= 24.9)
                {
                    Console.WriteLine("THE PERSON IS OVERWEIGHT");
                }
                else if (BMIlbs >= 25 && BMIlbs <= 29.9)
                {
                    Console.WriteLine("THE PERSON IS OVERWEIGHT");
                }
                else if (BMIlbs >= 30 && BMIlbs <= 34.9)
                {
                    Console.WriteLine("THE PERSON IS OBESE 1 CLASS");

                }
                else if (BMIlbs >= 35 && BMIlbs <= 39.9)
                {
                    Console.WriteLine("THE PERSON IS OBESE 2 CLASS");

                }
                else if (BMIlbs >= 40.0)
                {
                    Console.WriteLine("THE PERSON IS OBESE 3 CLASS");
                }


                Console.WriteLine("BAME MESSAGE");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("IF YOU ARE BLACK, ASIAN OR OTHER MINORITY YOU HAVE HIGHER RISK");
            }
        }
    }
}

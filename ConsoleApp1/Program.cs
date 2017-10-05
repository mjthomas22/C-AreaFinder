using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //users choice of shape
            string shape;
            bool input = true;
            //triangle variables
            double triangleBaseOutput = 0;
            double triangleHeightOutput = 0;
            string triangleChoice;
            double triangleArea;

            do
            {


                //Ask user what they want to find the area of
                Console.WriteLine("Find the area or circumference of a shape.");
                Console.WriteLine("1. Triangle \n2. Rectangle \n3. Trapezoid \n4. Parallelogram \n5. Circle \n6. Quit");

                shape = Console.ReadLine();

                Console.Clear();

                if (shape == "1")
                {
                    do
                    {
                        Console.Clear();
                        //gather information to get the area of a triangle
                        Console.WriteLine("To get the area of your triangle we need the base and the height of the triangle.");

                        Console.WriteLine("1. Enter the base.");

                        Console.WriteLine("2. Enter the height.");

                        //show user the current value of base
                        if (triangleBaseOutput != 0)
                        {
                            Console.WriteLine("\nYour current base is {0}", triangleBaseOutput);
                        }
                        //show user the current value of height
                        if (triangleHeightOutput != 0)
                        {
                            Console.WriteLine("Your current height is {0}", triangleHeightOutput);
                        }

                        Console.WriteLine("3. Calculate the area of your triangle.");

                        Console.WriteLine("4. Go back");

                        triangleChoice = Console.ReadLine();

                        Console.Clear();

                        //user enters the base of the triangle
                        if (triangleChoice == "1")
                        {

                            Console.WriteLine("Please enter the base of your triangle");
                            //checks to make sure user entered a number
                            input = double.TryParse(Console.ReadLine(), out triangleBaseOutput);

                            while (input == false)
                            {
                                Console.Clear();
                                Console.WriteLine("Please enter a number value for the base");
                                Console.WriteLine("Please enter the base of your triangle");
                                input = double.TryParse(Console.ReadLine(), out triangleBaseOutput);
                            }
                            Console.Clear();
                        }

                        //user enters the base of the triangle
                        if (triangleChoice == "2")
                        {

                            Console.WriteLine("Please enter the height of your triangle");
                            //checks to make sure user entered a number
                            input = double.TryParse(Console.ReadLine(), out triangleHeightOutput);

                            while (input == false)
                            {
                                Console.Clear();
                                Console.WriteLine("Please enter a number value for the height");
                                Console.WriteLine("Please enter the height of your triangle");
                                input = double.TryParse(Console.ReadLine(), out triangleHeightOutput);
                            }
                            Console.Clear();
                        }

                        //calculate area of triangle for the user
                        if (triangleChoice == "3")
                        {
                            Console.Clear();
                            triangleArea = .5 * triangleBaseOutput * triangleHeightOutput;
                            Console.WriteLine("Your triangle's area is {0}. Press enter to continue", triangleArea);
                            Console.ReadLine();
                        }

                    }
                    while (triangleChoice != "4");
                    Console.Clear();
                }
            }
            while (shape != "6");
            Console.Clear();
        }
    }
}

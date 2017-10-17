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

            //rectangle variables
            double rectangleWidthOutput = 0;
            double rectangleHeightOutput = 0;
            string rectangleChoice;
            double rectangleArea;

            //trapezoid variables
            double firstTrapezoidWidthOutput = 0;
            double secondTrapezoidWidthOutput = 0;
            double trapezoidHeightOutput = 0;
            string trapezoidChoice;
            double trapezoidArea;

            do
            {


                //Ask user what they want to find the area of
                Console.WriteLine("Find the area or circumference of a shape.");
                Console.WriteLine("1. Triangle \n2. Rectangle \n3. Trapezoid \n4. Parallelogram \n5. Circle \n6. Quit");

                shape = Console.ReadLine();

                Console.Clear();

                //Triangle Shape
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

                //Rectangle Shape
                if (shape == "2")
                {
                    do
                    {
                        Console.Clear();
                        //gather information to get the area of a triangle
                        Console.WriteLine("To get the area of your rectangle we need the width and height of the rectangle");

                        Console.WriteLine("1. Enter the width");

                        Console.WriteLine("2. Enter the height");

                        //show user the current value of rectangle width
                        if (rectangleWidthOutput != 0)
                        {
                            Console.WriteLine("\nYour current width is {0}.", rectangleWidthOutput);
                        }
                        //show user the current value of rectangle height
                        if (rectangleHeightOutput != 0)
                        {
                            Console.WriteLine("Your current height is {0}.", rectangleHeightOutput);
                        }

                        Console.WriteLine("3. Calculate the area of your rectangle");

                        Console.WriteLine("4. Go back");

                        rectangleChoice = Console.ReadLine();

                        Console.Clear();

                        //user enters the width of the rectangle
                        if (rectangleChoice == "1")
                        {

                            Console.WriteLine("Please enter the width of your rectangle.");
                            //checks to make sure user entered a number
                            input = double.TryParse(Console.ReadLine(), out rectangleWidthOutput);

                            while (input == false)
                            {
                                Console.Clear();
                                Console.WriteLine("Please enter a number value for the width.");
                                Console.WriteLine("Please enter the width of your rectangle.");
                                input = double.TryParse(Console.ReadLine(), out rectangleWidthOutput);
                            }
                            Console.Clear();
                        }

                        //user enters the height of the rectangle
                        if (rectangleChoice == "2")
                        {

                            Console.WriteLine("Please enter the height of your rectangle.");
                            //checks to make sure user entered a number
                            input = double.TryParse(Console.ReadLine(), out rectangleHeightOutput);

                            while (input == false)
                            {
                                Console.Clear();
                                Console.WriteLine("Please enter a number value for the height.");
                                Console.WriteLine("Please enter the height of your rectangle.");
                                input = double.TryParse(Console.ReadLine(), out rectangleHeightOutput);
                            }
                            Console.Clear();
                        }

                        //calculate area of rectangle for the user
                        if (rectangleChoice == "3")
                        {
                            Console.Clear();
                            rectangleArea = rectangleHeightOutput * rectangleWidthOutput;
                            Console.WriteLine("Your rectangles's area is {0}. Press enter to continue.", rectangleArea);
                            Console.ReadLine();
                        }

                    }
                    while (rectangleChoice != "4");
                    Console.Clear();
                }

                //Trapezoid Shape
                if (shape == "3")
                {
                    do
                    {
                        Console.Clear();
                        //gather information to get area of the trapezoid
                        Console.WriteLine("To get the area of your trapezoid we need the two widths and the height of the trapezoid.");
                        Console.WriteLine("1. First Width");
                        Console.WriteLine("2. Second Width");
                        Console.WriteLine("3. Height");

                        //show current values of widths and height
                        if (firstTrapezoidWidthOutput != 0)
                        {
                            Console.WriteLine("\nYour current first width is {0}", firstTrapezoidWidthOutput);
                        }
                        if (secondTrapezoidWidthOutput != 0)
                        {
                            Console.WriteLine("Your current second width is {0}", secondTrapezoidWidthOutput);
                        }
                        if (trapezoidHeightOutput != 0)
                        {
                            Console.WriteLine("Your current height is {0}", trapezoidHeightOutput);
                        }
                        Console.WriteLine("\n4. Calculate the area of your trapezoid");
                        Console.WriteLine("5. Go Back");

                        trapezoidChoice = Console.ReadLine();
                        Console.Clear();

                        if (trapezoidChoice == "1")
                        {
                            Console.WriteLine("Please enter the first width.");
                            input = double.TryParse(Console.ReadLine(), out firstTrapezoidWidthOutput);

                            while (input == false)
                            {
                                Console.Clear();
                                Console.WriteLine("Please enter a number value for the width.");
                                Console.WriteLine("Please enter the first width.");

                                input = double.TryParse(Console.ReadLine(), out firstTrapezoidWidthOutput);
                            }
                        }

                        if(trapezoidChoice == "2")
                        {
                            Console.WriteLine("Please enter the second width.");
                            input = double.TryParse(Console.ReadLine(), out secondTrapezoidWidthOutput);

                            while (input == false)
                            {
                                Console.Clear();
                                Console.WriteLine("Please enter a number value for the width.");
                                Console.WriteLine("Please enter the second width.");
                                input = double.TryParse(Console.ReadLine(), out secondTrapezoidWidthOutput);
                            }
                        }

                        if (trapezoidChoice == "3")
                        {
                            Console.WriteLine("Please enter the height.");
                            input = double.TryParse(Console.ReadLine(), out trapezoidHeightOutput);

                            while (input == false)
                            {
                                Console.Clear();
                                Console.WriteLine("Plase enter a number value for the height.");
                                Console.WriteLine("Please enter the height.");
                                input = double.TryParse(Console.ReadLine(), out trapezoidHeightOutput);
                            }
                        }

                        if
                    }

                }
            }
            while (shape != "6");
            Console.Clear();
        }
    }
}

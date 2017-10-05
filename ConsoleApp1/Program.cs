﻿using System;
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
            double shapeBase;
            double shapeHeight;
            string triangleChoice;

            do
            {


                //Ask user what they want to find the area of
                Console.WriteLine("Find the area or circumference of a shape.");
                Console.WriteLine("1. Triangle \n2. Rectangle \n 3. Trapezoid \n4. Parallelogram \n5. Circle \n6. Quit");

                shape = Console.ReadLine();

                Console.Clear();

                if (shape == "1")
                {
                    do
                    {
                        //gather information to get the area of a triangle
                        Console.WriteLine("To get the area of your triangle we need the base and the height of the triangle.");
                        Console.WriteLine("1. Enter the base.");

                        if (shapeBase != 0)
                        {
                            Console.WriteLine("Your current base is {0}", shapeBase);
                        }

                        Console.WriteLine("2. Enter the height.");

                        if (shapeHeight != 0)
                        {
                            Console.WriteLine("Your current height is {0}", shapeHeight);
                        }

                        Console.WriteLine("3. Calculate the area of your triangle.");
                        Console.WriteLine("4. Go back");
                        triangleChoice = Console.ReadLine();

                    }
                    while (triangleChoice == "4");

                }
            }
            while (shape != "6");
        }
    }
}

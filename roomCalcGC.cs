/*Room Calculator Lab
Marjorie Patton 10/04/21

Lab Summary: Explain in 3 detailed steps how to get input from the user, do calculations to the input to create a new variable, then display it back to the user.

Step 1: To get input from the user you have to declare the variable with the data type of the input you would like to receive, prompt the user to input the data, which will be read as
a string and then convert the data to the data type you declared when you declared the variable. 

Step 2: To do the calculations you use the variables you have declared and the correct arithmetic formulas, plugging in the input from the user and this will create a new value for the variable
for the instance you are currently working on.

Step 3: To display the information back to the user I choose to concatenate strings. I added what I wanted to be displayed to the variable and then let the console
print the results using the Console.WriteLine method.
*/


using System;

namespace RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            //declare variables
            double length;
            double width;
            double height;
            double area;
            double perimeter;
            double carpetTiles;
            double paint;
            double volume;
            string continueInput;


            //print greeting and prompt user for input of length width and height
            Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!");
            Console.WriteLine();
            Console.WriteLine("Enter Length:");

            length = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Width:");
            width = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Height:");
            height = double.Parse(Console.ReadLine());

            //calculations
            area = length * width;
            perimeter = 2 * (length + width);
            volume = length * width * height;
            carpetTiles = area / 5;
            paint = volume / 5;


            //results that display area, perimeter, carpetTiles and paint
            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);
            Console.WriteLine("CarpetTiles: " + carpetTiles);
            Console.WriteLine("Paint: " + paint);

            //Ask user if they want to continue

            {
                Console.WriteLine();
                Console.Write("Continue? (y/n): ");
                continueInput = (Console.ReadLine());

                // if else statement
                if (continueInput.ToLower() == "n")
                {
                    Console.WriteLine("The End");
                }
                else if (continueInput.ToLower() == "y")
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter Length:");

                    length = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Width:");
                    width = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Height:");
                    height = double.Parse(Console.ReadLine());

                    //calculations
                    area = length * width;
                    perimeter = 2 * (length + width);
                    volume = length * width * height;
                    carpetTiles = area / 5;
                    paint = volume / 5;


                    //results that display area, perimeter, carpetTiles and paint
                    Console.WriteLine("Area: " + area);
                    Console.WriteLine("Perimeter: " + perimeter);
                    Console.WriteLine("CarpetTiles: " + carpetTiles);
                    Console.WriteLine("Paint: " + paint);


                }
            }

        }
    }
}















using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        // define enum to store triangle types
        enum TriangleType
        {
            Equilateral,
            Isosceles,
            Scalene
        }
        static void Main(string[] args)
        {
            /* Triangle Type Identifier
            Write a program that prompts the user to enter three sides of a triangle. Based on the lengths 
            of the sides entered, determine and display the type of the triangle. The possible types are:
            - Equilateral: All three sides are equal.
            - Isosceles: Two sides are equal.
            - Scalene: No sides are equal.
            */

            // prompt user for input
            Console.WriteLine("Enter the three sides of the triangle.\nNB: Hit Enter to proceed to the next entry");

            // accept user input
            decimal side1 = Convert.ToDecimal(Console.ReadLine());
            decimal side2 = Convert.ToDecimal(Console.ReadLine());
            decimal side3 = Convert.ToDecimal(Console.ReadLine());


            // set default type to scalene
            string triangle = TriangleType.Scalene.ToString();

            // run checks to determine types of triangle
            if (side1 == side2 && side2 == side3) {
                triangle = TriangleType.Equilateral.ToString();
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                triangle = TriangleType.Isosceles.ToString();
            }
            else
            {
                triangle = TriangleType.Scalene.ToString();
            }


            

            Console.WriteLine($"The sides represents a/an:\n{triangle} triangle");
        }
    }
}

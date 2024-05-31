using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Grade Calculator
            Write a program that prompts the user to enter a numerical grade between 0 and 100.Based
             on the grade entered, display the corresponding letter grade using the following scale:
            -90 and above: A
            - 80 - 89: B
            - 70 - 79: C
            - 60 - 69: D
            - Below 60: F
            */

            // read user input
            Console.WriteLine("Enter a numerical grade in the range (0-100)");
            int grade = Convert.ToInt32(Console.ReadLine());

            // throw an exception if value is not in range

            try
            {
                if (grade < 0 || grade > 100) {
                    throw new ArithmeticException("Value must be between 0 and 100");
                }

                if (grade >= 90)
                {
                    Console.WriteLine("A");
                }
                else if (grade >= 80)
                {
                    Console.WriteLine("B");
                }
                else if (grade >= 70)
                {
                    Console.WriteLine("C");
                }
                else if (grade >= 60)
                {
                    Console.WriteLine("D");
                }
                else
                {
                    Console.WriteLine("F");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}

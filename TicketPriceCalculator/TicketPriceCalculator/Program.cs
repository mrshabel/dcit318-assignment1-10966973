namespace TicketPriceCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            A movie theater sells tickets for GHC10. However, if a customer is a senior citizen (age 65 
            and above) or a child (age 12 and below), they receive a discounted price of GHC7. Write a 
            program that prompts the user to enter their age and calculates the ticket price based on the 
            age entered. Display the ticket price accordingly.

            */

            double price = 10.00;
            double discount = 0.00;

            // prompt user for age
            Console.WriteLine("Enter your age here\n");

            // read user input
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 65 || age <= 12)
            {
                discount = 7.00;
            }

            // display price to user
            Console.WriteLine($"Your ticket price is GHC{price - discount}");
        }
    }
}

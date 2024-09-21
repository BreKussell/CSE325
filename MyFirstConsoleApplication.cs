using System;

namespace MyFirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables to store your name and location
            string myName = "Breanna"; 
            string myLocation = "That's a secret"; 
            
            // Output name and location using string interpolation
            Console.WriteLine($"My name is {myName}.");
            Console.WriteLine($"I am from {myLocation}.");
            
            // Output the current date without the time
            Console.WriteLine($"Today's date is: {DateTime.Now.ToShortDateString()}");

            // Calculate and output the number of days until Christmas this year
            DateTime today = DateTime.Now;
            DateTime christmas = new DateTime(today.Year, 12, 25);
            int daysUntilChristmas = (christmas - today).Days;

            // Display days until Christmas
            Console.WriteLine($"There are {daysUntilChristmas} days until Christmas this year.");
            
            // Program example from section 2.1 in the C# Programming Yellow Book (Rob Miles)
            // Asking for input and calculating the area of a rectangle
            Console.Write("Enter the width of the rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the height of the rectangle: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double area = width * height;

            // Output the calculated area with a label
            Console.WriteLine($"The area of the rectangle is {area} square units.");

            // Prevent the console from closing immediately
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
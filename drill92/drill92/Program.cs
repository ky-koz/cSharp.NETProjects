using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill92
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else if (weight <= 50)
            {
                Console.WriteLine("Please enter the package width: ");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height: ");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length: ");
                int length = Convert.ToInt32(Console.ReadLine());
                int size = width + length + height;
                double total = (double)(size * weight) / 100.00; //cannot get to display with two decimals, only one
                Console.WriteLine("Your estimated total for shipping this package is: $" + total + "\nThank you.");
            }
            else
            {
                Console.WriteLine("Oops! There was an error with your input.");
            }
            Console.Read();
        }
    }
}

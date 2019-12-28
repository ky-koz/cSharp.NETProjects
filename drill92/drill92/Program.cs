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
            float weight = float.Parse(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else if (weight <= 50)
            {
                Console.WriteLine("Please enter the package width: ");
                float width = float.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the package height: ");
                float height = float.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the package length: ");
                float length = float.Parse(Console.ReadLine());
                float size = width + length + height;
                if (size > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    double total = (double)(size * weight) / 100.00; //cannot get to display with two decimals, only one
                    Console.WriteLine("Your estimated total for shipping this package is: " + total.ToString("C", System.Globalization.CultureInfo.CurrentCulture) + "\nThank you.");
                    
                }
                
            }
            else
            {
                Console.WriteLine("Oops! There was an error with your input.");
            }
            Console.Read();
        }
    }
}

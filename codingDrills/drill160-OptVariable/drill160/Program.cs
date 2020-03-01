using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill160
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the class object
            Class2 operations = new Class2();


            Console.WriteLine("Choose a variable to perform math operations with.");
            Console.WriteLine("Please enter a whole number... ");
            int req = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Optional: Choose a second variable to perform math operations with.");
            Console.WriteLine("Please enter a whole number or just press enter to continue... ");

            //use tryparse instead of convert because an empty string is not a valid input for Convert.
            //set data type
            int opt;
            int result;

            //create if else for optional input
            if (Int32.TryParse(Console.ReadLine(), out opt))
            {
                result = operations.Math(req, opt);
                Console.WriteLine("{0} multiplied by {1} = {2}", req, opt, result);
            }
            else
            {
                result = operations.Math(req);
                Console.WriteLine("{0} multiplied by the default second value 5 = {1}", req, result);
            }
            
            Console.ReadLine();
            
        }
    }
}

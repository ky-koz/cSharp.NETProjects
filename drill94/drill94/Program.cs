using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill94
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You see $20 on the ground. You have five options:");
            Console.WriteLine("Option 1: See if someone around you dropped it.");
            Console.WriteLine("Option 2: Give it to a homeless person.");
            Console.WriteLine("Option 3: Put it in your wallet, carry on with your day.");
            Console.WriteLine("Option 4: Go and buy something with it.");
            Console.WriteLine("Option 5: Do nothing, keep walking.");
            Console.WriteLine("Please choose a response by typing the option number \"1-5\"");
            int number = Convert.ToInt32(Console.ReadLine());
            bool choice = number <= 5;

            do
            {
                switch(number)
                {
                    case 1:
                        Console.WriteLine("You chose Option 1. Way to be a good sumaritan.");
                        choice = true;
                        break;
                    case 2:
                        Console.WriteLine("You chose Option 2. You are a caring and generous person.");
                        choice = true;
                        break;
                    case 3:
                        Console.WriteLine("You chose Option 3. May as well.");
                        choice = true;
                        break;
                    case 4:
                        Console.WriteLine("You chose Option 4. Don't spend it all in one place!");
                        choice = true;
                        break;
                    case 5:
                        Console.WriteLine("You chose Option 5. Okay, maybe someone else will find it?");
                        choice = true;
                        break;
                    default:
                        Console.WriteLine("You did not choose a valid option.");
                        Console.WriteLine("Please choose again:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            while (!choice);
            Console.Read();
        }
    }
}

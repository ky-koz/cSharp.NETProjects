using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill66
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Takes an input from the user, multiplies it by 50, and prints the result to the console.
            Console.WriteLine("Type a number: ");
            string input1 = Console.ReadLine();
            int num1 = Convert.ToInt32(input1);
            int product = num1 * 50;
            Console.WriteLine(num1 + " * 50 = ");
            Console.WriteLine(product);
        
            //2. Takes an input from the user, adds 25 to it, and prints the result to the console.
            Console.WriteLine("Type a number: ");
            string input2 = Console.ReadLine();
            int num2 = Convert.ToInt32(input2);
            int sum = num2 + 25;
            Console.WriteLine(num2 + " + 25 = ");
            Console.WriteLine(sum);
            
            //3. Takes an input from the user, divides it by 12.5, and prints the result to the console.
            Console.WriteLine("Type a number: ");
            string input3 = Console.ReadLine();
            double num3 = Convert.ToDouble(input3);
            double quotient = num3 / 12.5;
            Console.WriteLine(num3 + " / 12.5 = ");
            Console.WriteLine(quotient);
            
            //4. Takes an input from the user, checks if it is greater than 50, and prints the true/false result to the console.
            Console.WriteLine("Type a number: ");
            string input4 = Console.ReadLine();
            int num4 = Convert.ToInt32(input4);
            bool trueOrFalse = num4 > 50;
            Console.WriteLine(num4 + " is greater than 50, true/false: ");
            Console.Write(trueOrFalse.ToString());
            
            //5. Takes an input from the user, divides it by 7, and prints the remainder to the console.
            Console.WriteLine("\nType a number: ");
            string input5 = Console.ReadLine();
            int num5 = Convert.ToInt32(input5);
            int remainder = num5 % 7;
            Console.WriteLine("The remainder of "+ num5 + " after being divided by 7: ");
            Console.WriteLine(remainder);

            Console.Read();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill147
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create a list of integers. Ask the user for a number to divide each number in the list by.Write a loop that 
            //takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.

            List<int> listA = new List<int>()
            {
                4, 6, 7, 20, 37, 10, 13, 2
            };

            //displays int items in listA
            foreach (int itemA in listA)
            {
                Console.WriteLine(itemA);
            }

            //asks user for int input to divide items in listA by
            Console.WriteLine("\nPlease type an integer to divide each item of the list by: ");
            int userInt = Convert.ToInt32(Console.ReadLine());
            
            //divide each item by user int
            foreach (int itemA in listA)
            {
                int newItem = itemA / userInt;
                Console.WriteLine("{0} divided by {1} equals {2}.", itemA, userInt, newItem);
            }


            Console.Read();
                
            //2.Run that code, entering in non - zero numbers as the user.Look at the displayed results.


            //3.Run that code, entering in zero as the number to divide by.Note any error messages you get.


            //4.Run that code, entering in a string as the number to divide by.Note any error messages you get.


            //5.Now put the loop in a try/catch block.Below and outside of the try/catch block, make the program 
            //print a message to the display to let you know the program has emerged from the try/catch block 
            //and continued on with program execution.In the catch block, display the error message to the screen.
            //Then try various combinations of user input: valid numbers, zero and a string.Ensure the proper 
            //error messages display on the screen, and that the code after the try/catch block gets executed.
        }
    }
}

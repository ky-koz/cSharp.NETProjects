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

            bool loop = true;
            while (loop == true)
            {
                try
                {
                    //asks user for int input to divide items in listA by
                    Console.WriteLine("\nPlease type an integer to divide each item of the list by: ");
                    int userInt = Convert.ToInt32(Console.ReadLine());

                    //divide each item by user int
                    foreach (int itemA in listA)
                    {
                        int newItem = itemA / userInt;
                        Console.WriteLine("{0} divided by {1} equals {2}.", itemA, userInt, newItem);
                    }
                    loop = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message); //will write out error message
                }
            }
            Console.WriteLine("The program has emerged from the try/catch block and continued on with program execution.");
            Console.Read();




            //2.Run that code, entering in non - zero numbers as the user.Look at the displayed results.

            //Please type an integer to divide each item of the list by:
            //    3
            //    4 divided by 3 equals 1.
            //    6 divided by 3 equals 2.
            //    7 divided by 3 equals 2.
            //    20 divided by 3 equals 6.
            //    37 divided by 3 equals 12.
            //    10 divided by 3 equals 3.
            //    13 divided by 3 equals 4.
            //    2 divided by 3 equals 0.
            //the int does not use decimals, there are remainder values in the equations

            //3.Run that code, entering in zero as the number to divide by.Note any error messages you get.

            //Unhandled Exception: System.DivideByZeroException: Attempted to divide by zero.
            //at drill147.Program.Main(String[] args) in C: \Users\Kyla Kozole\Desktop\Repositories\c#.NET\
            //drill147\drill147\Program.cs:line 34

            //4.Run that code, entering in a string as the number to divide by.Note any error messages you get.


            //5.Now put the loop in a try/catch block.Below and outside of the try/catch block, make the program 
            //print a message to the display to let you know the program has emerged from the try/catch block 
            //and continued on with program execution.In the catch block, display the error message to the screen.
            //Then try various combinations of user input: valid numbers, zero and a string.Ensure the proper 
            //error messages display on the screen, and that the code after the try/catch block gets executed.

            //string
            //g
            //Input string was not in a correct format.

            //zero
            //0
            //Attempted to divide by zero.
        }
    }
}

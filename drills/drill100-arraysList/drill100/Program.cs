using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill100
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an array of strings. ask the user to select an index of the 
            //array and then display the string at that index on the screen.
            string[] strArray = new string[10];
            strArray[0] = "milk";
            strArray[1] = "cheese";
            strArray[2] = "broccoli";
            strArray[3] = "bananas";
            strArray[4] = "lettuce";
            strArray[5] = "tomatoes";
            strArray[6] = "beans";
            strArray[7] = "rice";
            strArray[8] = "bread";
            strArray[9] = "butter";

            Console.WriteLine("Select a string index number between 0-9");
            int strIndex = Convert.ToInt32(Console.ReadLine());
            if (strIndex >= 0 && strIndex <= 9)
            {
                Console.WriteLine(strArray[strIndex]);
            }
            else
            {
                Console.WriteLine("That is not a valid index selection."); //would like to make this a loop to try again

            }


            //create an array of integers. ask the user to select an index of the 
            //array and then display the integer at that index on the screen.
            int[] intArray = new int[10];
            intArray[0] = 5;
            intArray[1] = 10;
            intArray[2] = 15;
            intArray[3] = 25;
            intArray[4] = 40;
            intArray[5] = 65;
            intArray[6] = 105;
            intArray[7] = 170;
            intArray[8] = 275;
            intArray[9] = 445;

            Console.WriteLine("Select an integer index number between 0-9");
            int userIndex = Convert.ToInt32(Console.ReadLine());
            if (userIndex >= 0 && userIndex <= 9)
            {
                Console.WriteLine(intArray[userIndex]);
            }
            else
            {
                Console.WriteLine("That is not a valid index selection."); //would like to make this a loop to try again
                
            }

            // create a lsit of strings. ask the user to select an index
            // of the list and then display the sontent at that index on the screen
            List<string> strList = new List<string>();
            strList.Add("one");
            strList.Add("two");
            strList.Add("three");
            strList.Add("four");
            strList.Add("five");
            strList.Add("six");


            Console.WriteLine("Select an string list index number between 0-5");
            int listIndex = Convert.ToInt32(Console.ReadLine());
            if (listIndex >= 0 && listIndex <= 5)
            {
                Console.WriteLine(strList[listIndex]);
            }
            else
            {
                Console.WriteLine("That is not a valid index selection."); //would like to make this a loop to try again

            }

            Console.ReadLine();
        }
    }
}

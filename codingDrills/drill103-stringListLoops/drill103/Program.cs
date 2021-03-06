﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill103
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create a one-dimensional Array of strings. Ask the user to input some text. 
            // Create a loop that goes through each string in the Array, adding the 
            // user’s text to the string. Then create a loop that prints off each string 
            // in the Array on a separate line.

            List<string> nameList = new List<string>()
                {
                "Johnson",
                "Proffit",
                "Smith",
                "Jackson",
                "Foster",
                "Wright",
                "Kaier",
                "Willoughby",
                "Nash",
                };
            Console.WriteLine("Please type your first name: ");
            string fname = Console.ReadLine() + " ";
            

            Console.WriteLine("\nThank you. \nYour name with diff last names:");
            
            for (int i = 0; i < nameList.Count; i++)
            {
                nameList[i] = fname + nameList[i];
                Console.WriteLine(nameList[i]);
            }
            
            Console.ReadLine();


            // 2. Create an infinite loop.
            // 3. Fix the infinite loop so it will execute.

            bool infinite = true;
            while (infinite)
            {
                Console.WriteLine("infinite");
                infinite = false;
            };
            Console.WriteLine();

            // 4. Create a loop where the comparison used to determine whether to continue 
            // iterating the loop is a “<” operator.

            int[] ages = { 23, 54, 64, 3, 16, 79, 90, 37 };
            for (int i = 0; i < ages.Length; i++)
            {
                if (ages[i] > 65)
                {
                    Console.WriteLine("Senior citizen age: " + ages[i]);
                }
            }
            Console.ReadLine();

            // 5. Create a loop where the comparison used to determine whether to continue 
            // iterating the loop is a “<=” operator.
            //have to use upper/lower bound to avoid out of range errors

            //using the list from the previous one
            for (int i = ages.GetLowerBound(0); i <= ages.GetUpperBound(0); i++)
            {
                if (ages[i] > 65)
                {
                    Console.WriteLine("Senior citizen age: " + ages[i]);
                }
            }
            Console.ReadLine();

            // 6. Create a List of strings where each item in the list is unique. Ask the 
            // user to select text to search for in the List. Create a loop that iterates 
            // through the list and then displays the index of the array that contains 
            // matching text on the screen.
            //7. Add code to that above loop that tells a user if they put in text that isn’t in the List.
            // 8. Add code to that above loop that stops it from executing once a match has 
            // been found.

            Console.WriteLine("Please type the name of a color below to see its index:");
            List<string> colorList = new List<string>()
            {
                "red",
                "blue",
                "green",
                "yellow",
                "purple",
                "orange",
            };
            foreach (string i in colorList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            string color = Console.ReadLine();

            for (int i = 0; i < colorList.Count; i++)
            {
                if (color == colorList[i])
                {
                    Console.WriteLine("The index of {0} is {1}.", color, i);
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, that input doesn't exist in the list.");
                    break;
                }
            };
            Console.WriteLine();

            
            // 9. Create a List of strings that has at least two identical strings in the 
            // List. Ask the user to select text to search for in the List. Create a loop 
            // that iterates through the list and then displays the indices of the array 
            // that contain matching text on the screen.
            // 10. Add code to that above loop that tells a user if they put in text that 
            // isn’t in the List.

            Console.WriteLine("Please type a string value below to see its indices:");
            List<string> doubleList = new List<string>()
            {
                "one", "two", "three", "two", "two",
                "four", "five", "five", "six", "seven"
            };

            // prints the list
            foreach (string i in doubleList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //user input
            string input = Console.ReadLine();

            // for loop to match user input with list items
            bool matchFound = false;
            for (int i = 0; i < doubleList.Count; i++)
            {
                if (input == doubleList[i])
                {
                    matchFound = true;
                    Console.WriteLine("The index of {0} is {1}.", input, i);
                }
                //else 
                //{
                //    Console.WriteLine("Sorry, that input doesn't exist in the list.");
                //    break;
                //}
            };
            if (matchFound == false)
            {
                Console.WriteLine("Sorry, that input doesn't exist in the list.");

            };

            Console.ReadLine();



            // 11. Create a List of strings that has at least two identical strings in the List. 
            // Create a foreach loop that evaluates each item in the list, and displays a 
            // message showing the string and whether or not it has already appeared in the list.

            Console.WriteLine("Here are the contents of list one:");
            List<string> listC = new List<string>()
            {
                "one", "two", "three", "two", "two",
                "four", "five", "five", "six", "seven"
            };

            foreach (string item1 in listC)
            {
                Console.WriteLine(item1);
            }
            Console.WriteLine();

            Console.WriteLine("Now checking for duplicates...");
            
            List<string> listCheck = new List<string>();
            foreach (string item1 in listC)
            {
                if (listCheck.Contains(item1))
                {
                    listCheck.Add(item1);
                    Console.WriteLine(item1 + " already exists.");
                }
                else
                {
                    listCheck.Add(item1);
                    Console.WriteLine(item1 + " does not already exist.");
                }
            };
            

            Console.Read();

        }
    }
}

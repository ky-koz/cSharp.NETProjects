using System;
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
            Console.WriteLine("Please type your last name: ");
            string lname = Console.ReadLine();
            nameList.Add(lname);

            Console.WriteLine("\nThank you. \nFull list of last names:");
         
            foreach (string i in nameList)
            Console.WriteLine(i);
            Console.ReadLine();


            // 2. Create an infinite loop.

            //bool infinite = true;
            //while (infinite)
            //{
            //    Console.WriteLine("infinite");
            //};

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

            int less = 99;
            if (less < 12)
            {
                Console.WriteLine(less + " is less than 12!");
                Console.ReadLine();
            }
            else if (less > 12)
            {
                Console.WriteLine(less + " is not less than 12.");
                Console.ReadLine();
            }

            // 5. Create a loop where the comparison used to determine whether to continue 
            // iterating the loop is a “<=” operator.

            int lessOr = 99;
            if (lessOr <= 20)
            {
                Console.WriteLine(less + " is less than or equal 20!");
                Console.ReadLine();
            }
            else if (lessOr > 12)
            {
                Console.WriteLine(lessOr + " is greater than 20.\n");
                Console.ReadLine();
            }

            // 6. Create a List of strings where each item in the list is unique. Ask the 
            // user to select text to search for in the List. Create a loop that iterates 
            // through the list and then displays the index of the array that contains 
            // matching text on the screen.

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
            Console.WriteLine(i);
            Console.WriteLine();

            string color = Console.ReadLine();

            for (int i = 0; i < colorList.Count; i++)
            {
                if (color == colorList[i])
                {
                    Console.WriteLine("make pretty" + i);
                    break;
                };
            };


            //var match = colorList.Where(element => element.Contains(color));
            //foreach(var i in match)
            //{
            //    if 
            //    {
            //        Console.WriteLine("The index of " + color + " is: " + colorList.IndexOf(i));

            //    };

            //};
            //Console.ReadLine();

            // 8. Add code to that above loop that stops it from executing once a match has 
            // been found.

        
            // 9. Create a List of strings that has at least two identical strings in the 
            // List. Ask the user to select text to search for in the List. Create a loop 
            // that iterates through the list and then displays the indices of the array 
            // that contain matching text on the screen.

            Console.WriteLine("Please type a string value below to see its indices:");
            List<string> doubleList = new List<string>()
            {
                "one", "two", "three", "two", "two",
                "four", "five", "five", "six", "seven"
            };

            string input = Console.ReadLine();

            for (int i = 0; i < colorList.Count; i++)
            {
                if (color == colorList[i])
                {
                    Console.WriteLine("make pretty" + i);
                };
            };

            Console.ReadLine();


            // 10. Add code to that above loop that tells a user if they put in text that 
            // isn’t in the List.

            // 11. Create a List of strings that has at least two identical strings in the List. 
            // Create a foreach loop that evaluates each item in the list, and displays a 
            // message showing the string and whether or not it has already appeared in the list.


            Console.Read();

        }
    }
}

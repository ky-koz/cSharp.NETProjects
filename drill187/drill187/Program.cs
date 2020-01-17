using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill187
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>(); //using generics
            employee.things = new List<string>()
            {
                "dog",
                "cat",
                "donkey",
                "chinchilla",
                "parakeet",
                "lizzard",
                "turtle",
                "horse",
                "flying squirrel",
            };

            Employee<int> employee2 = new Employee<int>(); //using generics
            employee2.things = new List<int>()
            {
                1, 2, 3, 5, 8, 13, 21, 34, 55, 89
            };

            Console.WriteLine("All the string things:");
            foreach (string thing in employee.things)
            {
                Console.WriteLine(thing);
            }

            Console.WriteLine();

            Console.WriteLine("All the int things:");
            foreach (int thing in employee2.things)
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();
        }
    }
}

//1. Make the Employee class take a generic type parameter.

//2. Add a property to the Employee class called "things" and have its data type be a 
//    generic list matching the generic type of the class.

//3. Instantiate an Employee object with type "string" as its generic parameter.Assign a 
//    list of strings as the property value of Things.

//4. Instantiate an Employee object with type "int" as its generic parameter.Assign a 
//    list of integers as the property value of Things.

//5. Create a loop that prints all of the Things to the Console.
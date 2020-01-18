using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill202_lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee();
            //employee.firstName = new employee.firstName();

            List<string> fName = new List<string>()
            {
                "George",
                "Linda",
                "Frank",
                "Joe",
                "Jeff",
                "Teri",
                "Joe",
                "Sally",
                "Jane",
                "Wes",
            };

            List<string> lName = new List<string>()
            {
                "Johnson",
                "Wilson",
                "Hunt",
                "Murdock",
                "Lane",
                "Anderson",
                "Smith",
                "Swensen",
                "Frost",
                "Robertson",
            };
            List<int> empId = new List<int>()
            {
                0, 1, 2, 3, 4, 5, 6, 7, 8, 9
            };

            //for loop
            foreach (string name in fName)
            {
                if (name == "Joe")
                {
                    Console.WriteLine(name);
                }
            }

            //lambda
            List<string> JoeList = fName.Where(x => x == "Joe").ToList();
            foreach (string joe in JoeList)
            {
                Console.WriteLine(joe);
            }

            List<int> idList = empId.Where(x => x > 5).ToList();
            foreach (int id in idList)
            {
                Console.WriteLine(id);
            }

            Console.ReadLine();
        }
    }
}

//1. In the Main() method, create a list of at least 10 employees.Each employee should have a first and 
//    last name, as well as an Id.At least two employees should have the first name "Joe".

//2. Using a foreach loop, create a new list of all employees with the first name "Joe".

//3. Do the same thing again, but this time with a lambda expression.

//4. Using a lambda expression, make a list of all employees with an Id number greater than 5.
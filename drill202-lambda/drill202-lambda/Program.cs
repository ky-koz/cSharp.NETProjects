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
            List<Employee> employees = new List<Employee>();
            Employee employee = new Employee();
            employees.Add(new Employee() { firstName = "George", lastName = "Johnson", empId = 0 });
            employees.Add(new Employee() { firstName = "Linda", lastName = "Wilson", empId = 1 });
            employees.Add(new Employee() { firstName = "Frank", lastName = "Hunt", empId = 2 });
            employees.Add(new Employee() { firstName = "Joe", lastName = "Murdock", empId = 3 });
            employees.Add(new Employee() { firstName = "Jeff", lastName = "Lane", empId = 4 });
            employees.Add(new Employee() { firstName = "Teri", lastName = "Anderson", empId = 5 });
            employees.Add(new Employee() { firstName = "Joe", lastName = "Smith", empId = 6 });
            employees.Add(new Employee() { firstName = "Sally", lastName = "Swensen", empId = 7 });
            employees.Add(new Employee() { firstName = "Jane", lastName = "Frost", empId = 8 });
            employees.Add(new Employee() { firstName = "Wes", lastName = "Robertson", empId = 9 });
            

            //for loop
            //foreach (Employee name in employees)
            //{
            //    if (name == "Joe")
            //    {
            //        Console.WriteLine(name);
            //    }
            //}

            //lambda
            List<Employee> JoeList = employees.Where(x => x.firstName == "Joe").ToList();
            foreach (Employee joe in JoeList)
            {
                Console.WriteLine("{0} {1} , EmpID: {2}",joe.firstName, joe.lastName, joe.empId);
            }

            List<Employee> idList = employees.Where(x => x.empId > 5).ToList();
            foreach (Employee id in idList)
            {
                Console.WriteLine("{0} {1} , EmpID: {2}", id.firstName, id.lastName, id.empId);
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
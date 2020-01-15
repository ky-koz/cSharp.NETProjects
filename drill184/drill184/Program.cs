using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill184
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Employee employee2 = new Employee();
            employee2.Id = "1628";
            employee.Id = "7651";

            Console.WriteLine("Do these employees have the same Id property?");
            if(employee.Id==employee2.Id)
            {
                Console.WriteLine("Yes, they are the same.");
            }
            else
            {
                Console.WriteLine("No, they are different.");
            }

            Console.ReadLine();
        }
    }
}

//1. Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.
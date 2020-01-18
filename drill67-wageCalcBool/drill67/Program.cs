using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill67
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            //person 1
            Console.WriteLine("Person 1");
            Console.WriteLine("Please input your information below: \n");
            Console.WriteLine("Hourly rate: ");
            int rate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week: ");
            int week1 = Convert.ToInt32(Console.ReadLine());
            int salary1 = rate1 * week1;

            //person 2
            Console.WriteLine("\nPerson 2");
            Console.WriteLine("Please input your information below: \n");
            Console.WriteLine("Hourly rate: ");
            int rate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week: ");
            int week2 = Convert.ToInt32(Console.ReadLine());
            int salary2 = rate2 * week2;

            //comparison fn
            Console.WriteLine("\nWeekly salary of Person 1: \n" + salary1);
            Console.WriteLine("Weekly salary of Person 2: \n" + salary2);
            bool trueOrFalse = salary1 > salary2;
            Console.WriteLine("Does Person 1 make more than Person 2?");
            Console.Write(trueOrFalse.ToString());

            Console.Read();

        }
    }
}

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
            string hourly1 = Console.ReadLine();
            int rate1 = Convert.ToInt32(hourly1);
            Console.WriteLine("Hours worked per week: ");
            string weekly1 = Console.ReadLine();
            int week1 = Convert.ToInt32(weekly1);
            int salary1 = rate1 * week1;

            //person 2
            Console.WriteLine("\nPerson 2");
            Console.WriteLine("Please input your information below: \n");
            Console.WriteLine("Hourly rate: ");
            string hourly2 = Console.ReadLine();
            int rate2 = Convert.ToInt32(hourly2);
            Console.WriteLine("Hours worked per week: ");
            string weekly2 = Console.ReadLine();
            int week2 = Convert.ToInt32(weekly2);
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

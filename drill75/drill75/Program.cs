using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill75
{
    class Program
    {
        static void Main(string[] args)
        {
            //questions
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Please answer \"true\" or \"false\"");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            //bool operators
            bool isQualified = (age > 15 && dui == false && tickets <= 3);    
            Console.WriteLine("Qualified?");
            Console.WriteLine(isQualified);
            Console.Read();

            //qualified
            //Console.WriteLine(true && true && true || false); //true
            //qualified = trueOrFalse
            //Console.WriteLine("Qualified? \n" + qualified)

            //     bool trueOrFalse = salary1 > salary2;
            //Console.WriteLine("Does Person 1 make more than Person 2?");
            //Console.Write(trueOrFalse.ToString());
            //Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            //string help = Console.ReadLine();
            //bool helpResponse = Convert.ToBoolean(help);
        }
    }
}

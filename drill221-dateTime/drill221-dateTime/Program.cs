using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill221_dateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);

            Console.WriteLine("Please type a whole number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            TimeSpan ts = TimeSpan.FromHours(x);
            Console.WriteLine(ts);

            Console.ReadLine();
        }
    }
}

//add user hours to current time to get exact time in future

//1. Prints the current date and time to the console.

//2. Asks the user for a number.

//3. Prints to the console the exact time it will be in X hours, X being 
//the number the user entered in step 2.
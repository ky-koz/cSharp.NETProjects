using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill55
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine(); #ctrl k c comment out, ctrl k u comment in

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.Read();

            //These are examples of how to use datatypes
            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemperature = -23;
            char questionMark = '\u2103';

            decimal moneyInBank = 100.5m;

            double heightInCentimeters = 211.30202092;

            float secondsLeft = 2.63f;

            short temperatureOnMars = -341;

            string myName = "Kyla";

            // casting examples
            int currentAge = 30;
            string yearsOld = currentAge.ToString();

            bool isRaining = false;
            string rainingStatus = Convert.ToString(isRaining);


            Console.WriteLine(rainingStatus);
            Console.ReadLine();


        }
    }
}

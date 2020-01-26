using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();

            DateTime now = DateTime.Now;

            System.DateTime DateOfBirth = new DateTime(2005, 5, 7);
            int CarYear = 2013;
            string CarMake = "porsche";
            string CarModel = "911 Carrera";
            bool DUI = true;
            int SpeedingTickets = 2;
            bool CoverageType = true;

            
            TimeSpan diff = now - DateOfBirth;
            int answer = Convert.ToInt32(diff.TotalDays);
            int total = answer / 365;
            Console.WriteLine(total); 
            //class1.One();

            
            Console.Read();
    }
}
}

//1.If the user is under 25, add $25 to the monthly total.

//2.If the user is under 18, add $100 to the monthly total.

//3.If the user is over 100, add $25 to the monthly total.

//4.If the car's year is before 2000, add $25 to the monthly total.

//5.If the car's year is after 2015, add $25 to the monthly total.

//6.If the car's Make is a Porsche, add $25 to the price.

//7.If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price.

//8.Add $10 to the monthly total for every speeding ticket the user has.

//9.If the user has ever had a DUI, add 25 % to the total.

//10.If it's full coverage, add 50% to the total.
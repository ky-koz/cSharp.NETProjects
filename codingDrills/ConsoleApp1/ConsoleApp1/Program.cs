using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();

            DateTime now = DateTime.Now;

            DateTime DateOfBirth = new DateTime(1990, 5, 7);
            int CarYear = 2016;
            string CarMake = "porsche";
            string CarModel = "911 Carrera";
            bool DUI = false;
            int SpeedingTickets = 2;
            bool CoverageType = false;

            
            TimeSpan diff = now - DateOfBirth;
            int answer = Convert.ToInt32(diff.TotalDays);
            int age = answer / 365;
            Console.WriteLine(age);
            int start = 50;

            //int monthlyTotal =

            //1.If the user is under 25, add $25 to the monthly total.
            if (age < 25 && age > 18)
            {
                start += 25;
            }

            //2.If the user is under 18, add $100 to the monthly total.
            else if (age < 18)
            {
                start += 100;
            }

            //3.If the user is over 100, add $25 to the monthly total.
            else if (age > 100)
            {
                start += 25;
            }
            //else
            //{
            //    start += 0;
            //}

            //4.If the car's year is before 2000, add $25 to the monthly total.
            if (CarYear < 2000)
            {
                start += 25;
            }
            //5.If the car's year is after 2015, add $25 to the monthly total.
            else if (CarYear > 2015)
            {
                start += 25;
            }
            //else
            //{
            //    start += 0;
            //}

            //6.If the car's Make is a Porsche, add $25 to the price.
            if (CarMake.ToLower() == "porsche")
            {
                start += 25;
            }
            //else
            //{
            //    start += 0;
            //}

            //7.If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price.
            if (CarMake.ToLower() == "porsche" && CarModel.ToLower() == "911 carrera")
            {
                start += 25;
            }
            //else
            //{
            //    start += 0;
            //}

            //8.Add $10 to the monthly total for every speeding ticket the user has.
            start += SpeedingTickets * 10;

            Console.WriteLine(start);
            double total = Convert.ToDouble(start);
            
            //9.If the user has ever had a DUI, add 25 % to the total.
            if (DUI)
            {
                total *= 1.25;
            }
            //else
            //{
            //    total *= 1;
            //}

            //10.If it's full coverage, add 50% to the total.
            if (CoverageType)
            {
                total *= 1.50;
            }
            //else
            //{
            //    total *= 1;
            //}

            Decimal quote = Convert.ToDecimal(total);
            Console.WriteLine(quote);
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
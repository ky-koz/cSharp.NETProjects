using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Class1
    {

        //public int Id { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public string EmailAddress { get; set; }
        //public System.DateTime DateOfBirth { get; set; }
        //public int CarYear { get; set; }
        //public string CarMake { get; set; }
        //public string CarModel { get; set; }
        //public bool DUI { get; set; }
        //public int SpeedingTickets { get; set; }
        //public bool CoverageType { get; set; }
        //public decimal Quote { get; set; }

        DateTime now = DateTime.Now;

        System.DateTime DateOfBirth = new DateTime(2005, 5, 7);
        int CarYear = 2013;
        string CarMake = "porsche";
        string CarModel = "911 Carrera";
        bool DUI = true;
        int SpeedingTickets = 2;
        bool CoverageType = true;

        public int One()
        {
            DateTime now = DateTime.Now;
            TimeSpan diff = now - DateOfBirth;
            int answer = Convert.ToInt32(diff.TotalDays);
            return answer;
        }
            ////Start with a base of $50 / month.
            //int start = 50;
            //DateTime now = DateTime.Today;
            //TimeSpan age = now - insuree.DateOfBirth;

            //int userAge = Convert.ToInt32(age);

            ////1.If the user is under 25, add $25 to the monthly total.
            //if (userAge< 18)
            //{
            //    Console.WriteLine("yes");
            //}

            //2.If the user is under 18, add $100 to the monthly total.

            //3.If the user is over 100, add $25 to the monthly total.

            //4.If the car's year is before 2000, add $25 to the monthly total.

            //5.If the car's year is after 2015, add $25 to the monthly total.

            //6.If the car's Make is a Porsche, add $25 to the price.

            //7.If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price.

            //8.Add $10 to the monthly total for every speeding ticket the user has.

            //9.If the user has ever had a DUI, add 25 % to the total.

            //10.If it's full coverage, add 50% to the total.

}
}

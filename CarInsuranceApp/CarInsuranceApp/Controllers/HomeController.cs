using CarInsuranceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsuranceApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CustomerInfo(string firstName, string lastName, string emailAddress, DateTime dateOfBirth,
                                          int carYear, string carMake, string carModel, bool dui, int speedingTickets,
                                          int insuranceType)
        {
            using (CarInsuranceEntities db = new CarInsuranceEntities())
            {
                var customerInfo = new CustomerInfo();
                customerInfo.FirstName = firstName;
                customerInfo.LastName = lastName;
                customerInfo.EmailAddress = emailAddress;
                customerInfo.DateOfBirth = dateOfBirth;
                customerInfo.CarYear = carYear;
                customerInfo.CarMake = carMake;
                customerInfo.CarModel = carModel;
                customerInfo.DUI = dui;
                customerInfo.SpeedingTickets = speedingTickets;
                customerInfo.InsuranceType = insuranceType;

                db.CustomerInfoes.Add(customerInfo);
                db.SaveChanges();
            }

            return View ("Success")
        }
        //{
        //    if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) || DateTime.IsNullOrEmpty(dateOfBirth) ||
        //        int (carYear) || string.IsNullOrEmpty(carMake) || string.IsNullOrEmpty(carModel) || bool.IsNullOrEmpty(dui) ||
        //        int.IsNullOrEmpty(speedingTickets) || int.IsNullOrEmpty(insuranceType))
        //    {
        //        return ViewContext("~V/Views/Shared/Error.cshtml)
        //    }
        //}

    }
}

//First Name

//Last Name

//Email Address

//Date of Birth

//Car Year

//Car Make

//Car Model

//If they have ever had a DUI.

//How many speeding tickets they have.

//Would they like full coverage or liability?
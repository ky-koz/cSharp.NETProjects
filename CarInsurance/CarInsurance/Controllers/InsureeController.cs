using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                DateTime now = DateTime.Now;
                TimeSpan diff = now - insuree.DateOfBirth;
                int answer = Convert.ToInt32(diff.TotalDays);
                int age = answer / 365;

                //Start with a base of $50 / month.
                int start = 50;


                //1.If the user is under 25, add $25 to the monthly total.
                //2.If the user is under 18, add $100 to the monthly total.
                //3.If the user is over 100, add $25 to the monthly total.
                if (age < 25 && age > 18)
                {
                    start += 25;
                }
                else if (age < 18)
                {
                    start += 100;
                }
                else if (age > 100)
                {
                    start += 25;
                }
                //4.If the car's year is before 2000, add $25 to the monthly total.
                //5.If the car's year is after 2015, add $25 to the monthly total.
                if (insuree.CarYear < 2000)
                {
                    start += 25;
                }
                else if (insuree.CarYear > 2015)
                {
                    start += 25;
                }
                //6.If the car's Make is a Porsche, add $25 to the price.
                if (insuree.CarMake.ToLower() == "porsche")
                {
                    start += 25;
                }
                //7.If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price.
                if (insuree.CarMake.ToLower() == "porsche" && insuree.CarModel.ToLower() == "911 carrera")
                {
                    start += 25;
                }
                //8.Add $10 to the monthly total for every speeding ticket the user has.
                start += insuree.SpeedingTickets * 10;

                double total = Convert.ToDouble(start);

                //9.If the user has ever had a DUI, add 25 % to the total.
                if (insuree.DUI)
                {
                    total *= 1.25;
                }
                //10.If it's full coverage, add 50% to the total.
                if (insuree.CoverageType)
                {
                    total *= 1.50;
                }

                insuree.Quote = Convert.ToDecimal(total);

                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                DateTime now = DateTime.Now;
                TimeSpan diff = now - insuree.DateOfBirth;
                int answer = Convert.ToInt32(diff.TotalDays);
                int age = answer / 365;
                Console.WriteLine(age);

                int start = 50;

                if (age < 25 && age > 18)
                {
                    start += 25;
                }
                else if (age < 18)
                {
                    start += 100;
                }
                else if (age > 100)
                {
                    start += 25;
                }
                if (insuree.CarYear < 2000)
                {
                    start += 25;
                }
                else if (insuree.CarYear > 2015)
                {
                    start += 25;
                }
                if (insuree.CarMake.ToLower() == "porsche")
                {
                    start += 25;
                }
                if (insuree.CarMake.ToLower() == "porsche" && insuree.CarModel.ToLower() == "911 carrera")
                {
                    start += 25;
                }
                start += insuree.SpeedingTickets * 10;

                double total = Convert.ToDouble(start);

                if (insuree.DUI)
                {
                    total *= 1.25;
                }
                if (insuree.CoverageType)
                {
                    total *= 1.50;
                }

                insuree.Quote = Convert.ToDecimal(total);
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}


//Start with a base of $50 / month.

//If the user is under 25, add $25 to the monthly total.

//If the user is under 18, add $100 to the monthly total.

//If the user is over 100, add $25 to the monthly total.

//If the car's year is before 2000, add $25 to the monthly total.

//If the car's year is after 2015, add $25 to the monthly total.

//If the car's Make is a Porsche, add $25 to the price.

//If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price.

//Add $10 to the monthly total for every speeding ticket the user has.

//If the user has ever had a DUI, add 25% to the total.

//If it's full coverage, add 50% to the total.
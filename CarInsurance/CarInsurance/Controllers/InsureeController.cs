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
                //add return Value for the quote
                //Start with a base of $50 / month.
                int start = 50;
                DateTime now = DateTime.Today;
                TimeSpan age = now - insuree.DateOfBirth;
                
                int userAge = Convert.ToInt32(age);
                //If the user is under 25, add $25 to the monthly total.
                if (userAge < 18)
                {
                    Console.WriteLine("yes");
                }

                //If the user is under 18, add $100 to the monthly total.

                //If the user is over 100, add $25 to the monthly total.

                //If the car's year is before 2000, add $25 to the monthly total.

                //If the car's year is after 2015, add $25 to the monthly total.

                //If the car's Make is a Porsche, add $25 to the price.

                //If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price.

                //Add $10 to the monthly total for every speeding ticket the user has.

                //If the user has ever had a DUI, add 25 % to the total.

                //If it's full coverage, add 50% to the total.

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
using CarInsurance.Models;
using System;
using System.Data.Entity;
using System.Net;
using System.Web.Mvc;
using System.Linq;
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
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree, bool fullCoverageSelected, string fullCoverageValue, bool v)
        {
            if (ModelState.IsValid)
            {
                decimal quote = 50.00m; // Start with a base of $50 / month.
                // Calculate Age
                var today = DateTime.Today;
                var age = today.Year - insuree.DateOfBirth.Year;
                // If the birthday hasn't happened yet this year, subtract one from age
                if (insuree.DateOfBirth.Date > today.AddYears(-age))
                {
                    age--;
                }
                // Age-based additions
                if (age <= 18)
                {
                    quote += 100.00m; // If the user is 18 or under, add $100
                }
                else if (age >= 19 && age <= 25)
                {
                    quote += 50.00m; // If the user is from 19 to 25, add $50
                }
                else // age >= 26
                {
                    quote += 25.00m; // If the user is 26 or older, add $25
                }
                // Car year additions
                if (insuree.CarYear < 2000)
                {
                    quote += 25.00m; // If the car's year is before 2000, add $25
                }
                if (insuree.CarYear > 2015)
                {
                    quote += 25.00m; // If the car's year is after 2015, add $25
                }
                // Car Make and Model additions
                if (insuree.CarMake == "Porsche")
                {
                    quote += 25.00m; // If the car's Make is a Porsche, add $25
                    if (insuree.CarModel == "911 Carrera")
                    {
                        quote += 25.00m; // If it's a 911 Carrera, add an ADDITIONAL $25
                    }
                }
                // Your original code had "Benz" checks here. I've removed them to stick to the assignment's explicit "Porsche" rule.
                // If you need to add logic for Benz cars, you'll need to define those rules.
                // Speeding Tickets
                quote += insuree.SpeedingTickets * 10.00m; // Add $10 for every speeding ticket
                // DUI
                if (insuree.DUI) // Assuming DUI is a boolean property
                {
                    quote *= 1.25m; // If the user has ever had a DUI, add 25% to the total.
                }
                // Coverage Type (Full coverage vs. Liability)
                if (insuree.CoverageType) // Assuming CoverageType is a boolean property (true for full coverage)
                {
                    quote *= 1.50m; // If it's full coverage, add 50% to the total.
                }
                insuree.Quote = Math.Round(quote, 2); // Assign the calculated quote, rounded to two decimal places
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            // If ModelState is not valid, return the view with the current insuree object
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
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
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
        public ActionResult Admin()
        {
            // Retrieve all insuree records from the database
            var insurees = db.Insurees.ToList();
            return View(insurees);
        }
    }
}
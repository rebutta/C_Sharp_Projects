using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using carInsurance.Models;

namespace carInsurance.Controllers
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
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = 50m; // starting quote value ALL ANSWERS HAVE CORRESPONDING LETTER //a
                DateTime age18 = new DateTime(5 / 12 / 2004); 
                if (insuree.DateOfBirth <= age18) //b
                {
                    insuree.Quote += 100m;
                }
                DateTime age19 = new DateTime(5 / 12 / 2003);
                DateTime age25 = new DateTime(5 / 12 / 1997);
                if (insuree.DateOfBirth > age19) //c
                {
                    if (insuree.DateOfBirth < age25)
                    {
                        insuree.Quote += 50m;
                    }
                }
                if (insuree.DateOfBirth > age25) //d
                {
                    insuree.Quote += 25m;
                }
                if (insuree.CarYear < 2000) //e
                {
                    insuree.Quote += 25m;
                }
                if (insuree.CarYear > 2015) //f
                {
                    insuree.Quote += 25m;
                }
                if (insuree.CarMake == "Porsche") //g
                {
                    insuree.Quote += 25m;
                    if (insuree.CarModel == "911 Carrera") //h
                    {
                        insuree.Quote += 25m;
                    }
                }                
                if (insuree.SpeedingTickets > 0) //i
                {
                    insuree.Quote += 10m * insuree.SpeedingTickets;
                }                
                if (insuree.DUI == true) //j
                {
                    decimal duiTax = insuree.Quote * 0.25m;
                    insuree.Quote += duiTax;
                }
                if (insuree.CoverageType == true) //k
                {
                    decimal fullCoverage = insuree.Quote * 0.5m;
                    insuree.Quote += fullCoverage;
                }

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
            return View(db.Insurees.ToList());
        }
    }
}

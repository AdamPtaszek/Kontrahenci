using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TestKontrahenci.DAL;
using TestKontrahenci.Models;

namespace TestKontrahenci.Controllers
{
    public class KontractorsController : Controller
    {
        private KontractorContext db = new KontractorContext();

        // GET: Kontractors
        public ActionResult Index()
        {
            return View(db.Kontractor.ToList());
        }

        // GET: Kontractors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kontractor kontractor = db.Kontractor.Find(id);
            if (kontractor == null)
            {
                return HttpNotFound();
            }
            return View(kontractor);
        }

        // GET: Kontractors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kontractors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Kontractor kontractor)
        {
            if (ModelState.IsValid)
            {
                db.Kontractor.Add(kontractor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kontractor);
        }

        // GET: Kontractors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kontractor kontractor = db.Kontractor.Find(id);
            if (kontractor == null)
            {
                return HttpNotFound();
            }
            return View(kontractor);
        }

        // POST: Kontractors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Kontractor kontractor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kontractor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kontractor);
        }

        // GET: Kontractors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kontractor kontractor = db.Kontractor.Find(id);
            if (kontractor == null)
            {
                return HttpNotFound();
            }
            return View(kontractor);
        }

        // POST: Kontractors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Kontractor kontractor = db.Kontractor.Find(id);
            db.Kontractor.Remove(kontractor);
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

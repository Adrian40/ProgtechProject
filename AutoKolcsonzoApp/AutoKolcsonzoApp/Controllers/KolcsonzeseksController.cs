using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AutoKolcsonzoApp.Models;

namespace AutoKolcsonzoApp.Controllers
{
    public class KolcsonzeseksController : Controller
    {
        private AutokolcsonzoEntities db = new AutokolcsonzoEntities();

        // GET: Kolcsonzeseks
        public ActionResult Index()
        {
            var kolcsonzeseks = db.Kolcsonzeseks.Include(k => k.Autok).Include(k => k.Vevok);
            return View(kolcsonzeseks.ToList());
        }

        // GET: Kolcsonzeseks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kolcsonzesek kolcsonzesek = db.Kolcsonzeseks.Find(id);
            if (kolcsonzesek == null)
            {
                return HttpNotFound();
            }
            return View(kolcsonzesek);
        }

        // GET: Kolcsonzeseks/Create
        public ActionResult Create()
        {
            ViewBag.AutoID = new SelectList(db.Autoks, "AutoID", "Marka");
            ViewBag.VevokID = new SelectList(db.Vevoks, "VevoID", "VezetekNev");
            return View();
        }

        // POST: Kolcsonzeseks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "KolcsonzesID,VevokID,AutoID,KolcsonzesIdeje")] Kolcsonzesek kolcsonzesek)
        {
            if (ModelState.IsValid)
            {
                db.Kolcsonzeseks.Add(kolcsonzesek);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AutoID = new SelectList(db.Autoks, "AutoID", "Marka", kolcsonzesek.AutoID);
            ViewBag.VevokID = new SelectList(db.Vevoks, "VevoID", "VezetekNev", kolcsonzesek.VevokID);
            return View(kolcsonzesek);
        }

        // GET: Kolcsonzeseks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kolcsonzesek kolcsonzesek = db.Kolcsonzeseks.Find(id);
            if (kolcsonzesek == null)
            {
                return HttpNotFound();
            }
            ViewBag.AutoID = new SelectList(db.Autoks, "AutoID", "Marka", kolcsonzesek.AutoID);
            ViewBag.VevokID = new SelectList(db.Vevoks, "VevoID", "VezetekNev", kolcsonzesek.VevokID);
            return View(kolcsonzesek);
        }

        // POST: Kolcsonzeseks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "KolcsonzesID,VevokID,AutoID,KolcsonzesIdeje")] Kolcsonzesek kolcsonzesek)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kolcsonzesek).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AutoID = new SelectList(db.Autoks, "AutoID", "Marka", kolcsonzesek.AutoID);
            ViewBag.VevokID = new SelectList(db.Vevoks, "VevoID", "VezetekNev", kolcsonzesek.VevokID);
            return View(kolcsonzesek);
        }

        // GET: Kolcsonzeseks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kolcsonzesek kolcsonzesek = db.Kolcsonzeseks.Find(id);
            if (kolcsonzesek == null)
            {
                return HttpNotFound();
            }
            return View(kolcsonzesek);
        }

        // POST: Kolcsonzeseks/Delete/5
        [HttpPost, ActionName("Törlés")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Kolcsonzesek kolcsonzesek = db.Kolcsonzeseks.Find(id);
            db.Kolcsonzeseks.Remove(kolcsonzesek);
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

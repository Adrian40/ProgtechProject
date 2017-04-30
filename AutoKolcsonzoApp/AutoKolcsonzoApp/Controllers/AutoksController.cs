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
    public class AutoksController : Controller
    {
        private AutokolcsonzoEntities db = new AutokolcsonzoEntities();

        // GET: Autoks
        public ActionResult Index()
        {
            return View(db.Autoks.ToList());
        }

        // GET: Autoks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Autok autok = db.Autoks.Find(id);
            if (autok == null)
            {
                return HttpNotFound();
            }
            return View(autok);
        }

        // GET: Autoks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Autoks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AutoID,Marka,Rendszam,Szin,UlesekSzama")] Autok autok)
        {
            if (ModelState.IsValid)
            {
                db.Autoks.Add(autok);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(autok);
        }

        // GET: Autoks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Autok autok = db.Autoks.Find(id);
            if (autok == null)
            {
                return HttpNotFound();
            }
            return View(autok);
        }

        // POST: Autoks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AutoID,Marka,Rendszam,Szin,UlesekSzama")] Autok autok)
        {
            if (ModelState.IsValid)
            {
                db.Entry(autok).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(autok);
        }

        // GET: Autoks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Autok autok = db.Autoks.Find(id);
            if (autok == null)
            {
                return HttpNotFound();
            }
            return View(autok);
        }

        // POST: Autoks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Autok autok = db.Autoks.Find(id);
            db.Autoks.Remove(autok);
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

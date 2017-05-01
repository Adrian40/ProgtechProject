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
    public class VevoksController : Controller
    {
        private AutokolcsonzoEntities db = new AutokolcsonzoEntities();

        // GET: Vevoks
        public ActionResult Index()
        {
            return View(db.Vevoks.ToList());
        }

        // GET: Vevoks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vevok vevok = db.Vevoks.Find(id);
            if (vevok == null)
            {
                return HttpNotFound();
            }
            return View(vevok);
        }

        // GET: Vevoks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Vevoks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VevoID,VezetekNev,KeresztNev,TelefonSzam,Email")] Vevok vevok)
        {
            if (ModelState.IsValid)
            {
                db.Vevoks.Add(vevok);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vevok);
        }

        // GET: Vevoks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vevok vevok = db.Vevoks.Find(id);
            if (vevok == null)
            {
                return HttpNotFound();
            }
            return View(vevok);
        }

        // POST: Vevoks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VevoID,VezetekNev,KeresztNev,TelefonSzam,Email")] Vevok vevok)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vevok).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vevok);
        }

        // GET: Vevoks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vevok vevok = db.Vevoks.Find(id);
            if (vevok == null)
            {
                return HttpNotFound();
            }
            return View(vevok);
        }

        // POST: Vevoks/Delete/5
        [HttpPost, ActionName("Törlés")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Vevok vevok = db.Vevoks.Find(id);
            db.Vevoks.Remove(vevok);
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

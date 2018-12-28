using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using labtestportal.Model;

namespace labtestportal.Controllers
{
    public class Pers_GenderController : Controller
    {
        private labTestPortalEntities db = new labTestPortalEntities();

        // GET: Pers_Gender
        public ActionResult Index()
        {
            return View(db.Pers_Gender.ToList());
        }

        // GET: Pers_Gender/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pers_Gender pers_Gender = db.Pers_Gender.Find(id);
            if (pers_Gender == null)
            {
                return HttpNotFound();
            }
            return View(pers_Gender);
        }

        // GET: Pers_Gender/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pers_Gender/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "gender_id,Gender")] Pers_Gender pers_Gender)
        {
            if (ModelState.IsValid)
            {
                db.Pers_Gender.Add(pers_Gender);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pers_Gender);
        }

        // GET: Pers_Gender/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pers_Gender pers_Gender = db.Pers_Gender.Find(id);
            if (pers_Gender == null)
            {
                return HttpNotFound();
            }
            return View(pers_Gender);
        }

        // POST: Pers_Gender/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "gender_id,Gender")] Pers_Gender pers_Gender)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pers_Gender).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pers_Gender);
        }

        // GET: Pers_Gender/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pers_Gender pers_Gender = db.Pers_Gender.Find(id);
            if (pers_Gender == null)
            {
                return HttpNotFound();
            }
            return View(pers_Gender);
        }

        // POST: Pers_Gender/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pers_Gender pers_Gender = db.Pers_Gender.Find(id);
            db.Pers_Gender.Remove(pers_Gender);
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

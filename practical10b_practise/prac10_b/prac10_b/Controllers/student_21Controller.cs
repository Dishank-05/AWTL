using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using prac10_b;
using EntityState = System.Data.Entity.EntityState;

namespace prac10_b.Controllers
{
    public class student_21Controller : Controller
    {
        private rushikesh_21Entities db = new rushikesh_21Entities();

        // GET: student_21
        public ActionResult Index()
        {
            return View(db.student_21.ToList());
        }

        // GET: student_21/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            student_21 student_21 = db.student_21.Find(id);
            if (student_21 == null)
            {
                return HttpNotFound();
            }
            return View(student_21);
        }

        // GET: student_21/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: student_21/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Email,Roll_No,Program")] student_21 student_21)
        {
            if (ModelState.IsValid)
            {
                db.student_21.Add(student_21);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(student_21);
        }

        // GET: student_21/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            student_21 student_21 = db.student_21.Find(id);
            if (student_21 == null)
            {
                return HttpNotFound();
            }
            return View(student_21);
        }

        // POST: student_21/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Email,Roll_No,Program")] student_21 student_21)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student_21).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student_21);
        }

        // GET: student_21/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            student_21 student_21 = db.student_21.Find(id);
            if (student_21 == null)
            {
                return HttpNotFound();
            }
            return View(student_21);
        }

        // POST: student_21/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            student_21 student_21 = db.student_21.Find(id);
            db.student_21.Remove(student_21);
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using bookyourdoctor;

namespace bookyourdoctor.Controllers
{
    public class doctor_sceduleController : Controller
    {
        private FINALSCRIPTEntities db = new FINALSCRIPTEntities();

        // GET: doctor_scedule
        public ActionResult Index()
        {
            return View(db.doctor_scedule.ToList());
        }

        // GET: doctor_scedule/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            doctor_scedule doctor_scedule = db.doctor_scedule.Find(id);
            if (doctor_scedule == null)
            {
                return HttpNotFound();
            }
            return View(doctor_scedule);
        }

        // GET: doctor_scedule/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: doctor_scedule/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "clinic_time,hospital_time,is_avalible,Clinic_day,hospial_day,doctor_id,clinic_end_time,hospital_end_time")] doctor_scedule doctor_scedule)
        {
            if (ModelState.IsValid)
            {
                db.doctor_scedule.Add(doctor_scedule);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(doctor_scedule);
        }

        // GET: doctor_scedule/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            doctor_scedule doctor_scedule = db.doctor_scedule.Find(id);
            if (doctor_scedule == null)
            {
                return HttpNotFound();
            }
            return View(doctor_scedule);
        }

        // POST: doctor_scedule/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "clinic_time,hospital_time,is_avalible,Clinic_day,hospial_day,doctor_id,clinic_end_time,hospital_end_time")] doctor_scedule doctor_scedule)
        {
            if (ModelState.IsValid)
            {
                db.Entry(doctor_scedule).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(doctor_scedule);
        }

        // GET: doctor_scedule/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            doctor_scedule doctor_scedule = db.doctor_scedule.Find(id);
            if (doctor_scedule == null)
            {
                return HttpNotFound();
            }
            return View(doctor_scedule);
        }

        // POST: doctor_scedule/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            doctor_scedule doctor_scedule = db.doctor_scedule.Find(id);
            db.doctor_scedule.Remove(doctor_scedule);
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

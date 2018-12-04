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
    public class Hospital_requestController : Controller
    {
        private FINALSCRIPTEntities db = new FINALSCRIPTEntities();

        // GET: Hospital_request
        public ActionResult Index()
        {
            return View(db.Hospital_request.ToList());
        }

        // GET: Hospital_request/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hospital_request hospital_request = db.Hospital_request.Find(id);
            if (hospital_request == null)
            {
                return HttpNotFound();
            }
            return View(hospital_request);
        }

        // GET: Hospital_request/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hospital_request/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Hospital_time,date,is_request,patient_name,Hospital_day,Request_Status,doctor_id")] Hospital_request hospital_request)
        {
            if (ModelState.IsValid)
            {
                db.Hospital_request.Add(hospital_request);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hospital_request);
        }

        // GET: Hospital_request/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hospital_request hospital_request = db.Hospital_request.Find(id);
            if (hospital_request == null)
            {
                return HttpNotFound();
            }
            return View(hospital_request);
        }

        // POST: Hospital_request/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Hospital_time,date,is_request,patient_name,Hospital_day,Request_Status,doctor_id")] Hospital_request hospital_request)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hospital_request).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hospital_request);
        }

        // GET: Hospital_request/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hospital_request hospital_request = db.Hospital_request.Find(id);
            if (hospital_request == null)
            {
                return HttpNotFound();
            }
            return View(hospital_request);
        }

        // POST: Hospital_request/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Hospital_request hospital_request = db.Hospital_request.Find(id);
            db.Hospital_request.Remove(hospital_request);
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NearEarthObjectTracker.Models;
using System.IO;

namespace NearEarthObjectTracker.Controllers
{
    public class User_PanelController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: User_Panel
        public ActionResult Index()
        {
            return View(db.User_Panel.ToList());
        }
        //public ActionResult FileUpload(HttpPostedFileBase file)
        //{

        //    if (file != null)
        //    {
        //        ImagesDBModel2 db = new ImagesDBModel2();
        //        string ImageName = System.IO.Path.GetFileName(file.FileName);
        //        string physicalPath = Server.MapPath("~/images/" + ImageName);

        //        // save image in folder
        //        file.SaveAs(physicalPath);

        //        //save new record in database
        //        ImagesTable newRecord = new ImagesTable();
        //        db.ImagesTables.Add(newRecord);
        //        db.SaveChanges();

        //    }
        //    //Display records
        //    return RedirectToAction("User_Panel");
        //}

        // GET: User_Panel/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User_Panel user_Panel = db.User_Panel.Find(id);
            if (user_Panel == null)
            {
                return HttpNotFound();
            }
            return View(user_Panel);
        }

        // GET: User_Panel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User_Panel/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id")] User_Panel user_Panel)
        {
            if (ModelState.IsValid)
            {
                db.User_Panel.Add(user_Panel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(user_Panel);
        }

        // GET: User_Panel/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User_Panel user_Panel = db.User_Panel.Find(id);
            if (user_Panel == null)
            {
                return HttpNotFound();
            }
            return View(user_Panel);
        }

        // POST: User_Panel/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id")] User_Panel user_Panel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user_Panel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user_Panel);
        }

        // GET: User_Panel/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User_Panel user_Panel = db.User_Panel.Find(id);
            if (user_Panel == null)
            {
                return HttpNotFound();
            }
            return View(user_Panel);
        }

        // POST: User_Panel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User_Panel user_Panel = db.User_Panel.Find(id);
            db.User_Panel.Remove(user_Panel);
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

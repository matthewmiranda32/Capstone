using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NearEarthObjectTracker.Models;

namespace NearEarthObjectTracker.Controllers
{
    public class Meteor_ShowersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Meteor_Showers
        public ActionResult Index()
        {
            return View(db.Meteor_Showers);
        }

        // GET: Meteor_Showers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Meteor_Showers meteor_Showers = db.Meteor_Showers.Find(id);
            if (meteor_Showers == null)
            {
                return HttpNotFound();
            }
            return View(meteor_Showers);
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

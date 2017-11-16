using NearEarthObjectTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using static System.Net.WebRequestMethods;

namespace NearEarthObjectTracker.Controllers
{
    public class NEOsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        //GET NEOsAPI
        public ActionResult Index()
        {
            return View(db.NearEarthObjects);
        }

    }
}
            


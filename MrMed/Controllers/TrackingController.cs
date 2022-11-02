using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MrMed.Controllers
{
    public class TrackingController : Controller
    {
        // GET: Tracking
        public ActionResult Tracking()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Tracking(tracking obj)



        {
            if (ModelState.IsValid)
            {
                RitikaTestEntities1 db = new RitikaTestEntities1();
                db.trackings.Add(obj);

                db.SaveChanges();
            }
            return View(obj);
        }
    }
}

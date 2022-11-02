using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MrMed.Controllers
{
    public class InsuranceController : Controller
    {
        // GET: Insurance
        public ActionResult Insurance()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insurance(Insurance obj)



        {
            if (ModelState.IsValid)
            {
                RitikaTestEntities1 db = new RitikaTestEntities1();
                db.Insurances.Add(obj);

                db.SaveChanges();
            }
            return View(obj);
        }

    }
}
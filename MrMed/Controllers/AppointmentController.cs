using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MrMed.Controllers
{
    public class AppointmentController : Controller
    {
        // GET: Appointment
        public ActionResult Appointment()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Appointment(Appointment obj)



        {
            if (ModelState.IsValid)
            {
                RitikaTestEntities db = new RitikaTestEntities();
                db.Appointments.Add(obj);
             
                db.SaveChanges();
            }
            return View(obj);
        }
    }
}

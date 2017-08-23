using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentalAgency.Controllers
{
    public class RentalController : Controller
    {
        // GET: Rental
        public ActionResult Rental() {

            ViewBag.Message = "Rental page";

            return View();
        }
    }
}
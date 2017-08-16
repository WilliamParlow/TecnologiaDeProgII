using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentalAgency.Controllers {
    public class MovieController : Controller {

        public ActionResult Movies() {

            ViewBag.Message = "Movies page";

            return View();
        }

        public ActionResult Games() {

            ViewBag.Message = "Games page";

            return View();
        }

        public ActionResult Costumer() {

            ViewBag.Message = "Costumer page";

            return View();
        }

        public ActionResult Rental() {

            ViewBag.Message = "Rental page";

            return View();
        }

    }
}
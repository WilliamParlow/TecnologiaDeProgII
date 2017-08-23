using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentalAgency.Content
{
    public class CostumerController : Controller
    {
        // GET: Costumer
        public ActionResult Costumer() {

            ViewBag.Message = "Costumer page";

            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentalAgency.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Games() {

            ViewBag.Message = "Games page";

            return View();
        }
    }
}
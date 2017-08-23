using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentalAgency.Models;

namespace RentalAgency.Controllers {
    public class MovieController : Controller {

        List<Movie> movies = new List<Movie>(){
            new Movie() { Name = "Shrek!", Id = 1, Duration = 180, Genre = "Comedy" },
            new Movie() { Name = "IT", Id = 2, Duration = 173, Genre = "Horror" },
            new Movie() { Name = "The sect", Id = 3, Duration = 130, Genre = "Horror" },
            new Movie() { Name = "Exorcism of Emily Rose", Id = 4, Duration = 160, Genre = "Horror" }
        };

        public ActionResult HomePage() {

            ViewBag.Message = "Home page";

            return View();
        }

        public ActionResult Movies() {

            

            
            return View(movies);
        }

        public ActionResult Details(int id) {

            if (id > 4) return HttpNotFound();

            return View(movies.Find(predicted => predicted.Id == id));

        }

    }
}
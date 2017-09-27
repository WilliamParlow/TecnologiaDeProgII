using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using RentalAgency.Models;

namespace RentalAgency.Controllers {
    public class MovieController : Controller {

        /* 
         
            Propriedades da classe 
         
        */
        private ApplicationDbContext _context;


        /* 
         
            Construtores 
         
        */
        public MovieController() {
            this._context = new ApplicationDbContext();
            this._context.Costumers.Include(c => c.MembershipType).ToList();
        }



        /* 
         
            Action Results
         
        */
        public ActionResult HomePage() {

            ViewBag.Message = "Home page";

            return View();
        }

        public ActionResult Movies() {

            var movies = this._context.Movies.ToList();

            return View(movies);
        }

        public ActionResult Details(int id) {

            var movies = this._context.Movies.ToList();

            if (id > movies.Count) return HttpNotFound();

            return View(movies.Find(predicted => predicted.Id == id));

        }



        /* 
         
            Overrides 
         
        */
        protected override void Dispose(bool disposing) {
            this._context.Dispose();
        }

    }
}
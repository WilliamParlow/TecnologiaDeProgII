using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using RentalAgency.Models;
using RentalAgency.ViewModels;

namespace RentalAgency.Controllers {
    public class MovieController : Controller {




        /* 
         
            Propriedades da classe 
         
        */
        private ApplicationDbContext _dbContext;





        /* 
         
            Construtores 
         
        */
        public MovieController() {
            this._dbContext = new ApplicationDbContext();
            this._dbContext.Costumers.Include(c => c.MembershipType).ToList();
        }





        /* 
         
            Action Results
         
        */
        public ActionResult HomePage() {

            ViewBag.Message = "Home page";

            return View();
        }

        public ActionResult Movies() {

            var MovieIndexView = new MovieIndexViewModel() {
                Movies = this._dbContext.Movies.ToList()
            };

            return View(MovieIndexView.Movies);
        }

        public ActionResult Details(int id) {

            var movies = this._dbContext.Movies.ToList();

            if (id > movies.Count) return HttpNotFound();

            return View(movies.Find(predicted => predicted.Id == id));

        }







        /* 
         
            CRUD Actions
         
        */
        public ActionResult Edit(int id) {

            var movie = this._dbContext.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();



            var movieViewModel = new MovieFormViewModel() {
                Movie = movie
            };


            return View("FormMovie", movieViewModel);

        }

        public ActionResult New() {

            var movieViewModel = new MovieFormViewModel();

            return View("FormMovie", movieViewModel);

        }


        [HttpPost]
        public ActionResult Delete(int id) {

            var movie = this._dbContext.Movies.SingleOrDefault(m => m.Id == id);

            if (movie != null) {

                this._dbContext.Entry(movie).State = EntityState.Deleted;
                this._dbContext.SaveChanges();

            }

            return RedirectToAction("Movies");

        }

        [HttpPost] // Will be access just with POST method
        public ActionResult Save(Movie movie) {

            if (movie.Id != 0) {

                _dbContext.Entry(movie).State = EntityState.Modified;

            } else {

                _dbContext.Movies.Add(movie);

            }

            _dbContext.SaveChanges();


            return RedirectToAction("Movies");
        }






        /* 
         
            Overrides 
         
        */
        protected override void Dispose(bool disposing) {
            this._dbContext.Dispose();
        }

    }
}
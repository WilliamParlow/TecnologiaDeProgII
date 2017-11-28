using RentalAgency.Models;
using RentalAgency.ViewModels;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace RentalAgency.Controllers {

   public class MovieController : Controller {




      /* 

          Propriedades da classe 

      */
      private ApplicationDbContext _dbContext = new ApplicationDbContext();





      /* 

          Construtores 

      */
      public MovieController() {
         _dbContext.Movies.Include(m => m.Category).ToList();
      }





      /* 

          Action Results

      */

      [AllowAnonymous]
      public ActionResult HomePage() {

         ViewBag.Message = "Home page";

         return View();
      }
      
      public ActionResult Movies() {

         var MovieIndexView = new MovieIndexViewModel() {
            Movies = _dbContext.Movies.ToList()
         };

         return View(MovieIndexView.Movies);
      }



      public ActionResult Details(int id) {

         var movie = _dbContext.Movies.ToList().Find(predicted => predicted.Id == id);

         if (movie == null) return HttpNotFound();

         return View(movie);

      }







      /* 

          CRUD Actions

      */
      public ActionResult Edit(int id) {

         var movie = _dbContext.Movies.SingleOrDefault(m => m.Id == id);

         if (movie == null)
            return HttpNotFound();
         

         var movieViewModel = new MovieFormViewModel() {
            Movie = movie,
            Categories = _dbContext.Category.ToList()
         };


         return View("FormMovie", movieViewModel);

      }



      public ActionResult New() {

         var movieViewModel = new MovieFormViewModel() {
            Categories = _dbContext.Category.ToList()
         };

         ViewBag.CategoryId = new SelectList(_dbContext.Category, "Id", "CategoryName");
         return View("FormMovie", movieViewModel);

      }



      [HttpPost] // Will be access just with POST method
      [ValidateAntiForgeryToken]
      public ActionResult Save(Movie movie) {

         ModelState.Remove("movie.Id");
         ModelState.Remove("movie.CategoryId");
         if (!ModelState.IsValid) {

            var viewModel = new MovieFormViewModel {
               Movie = movie,
               Categories = _dbContext.Category.ToList()
            };

            return View("FormMovie", viewModel);
         }

         if (movie.Id == 0) {

            _dbContext.Movies.Add(movie);

         } else {

            Movie dbMovieContext = _dbContext.Movies.Single(m => m.Id == movie.Id);

            dbMovieContext.CategoryId = movie.CategoryId;
            dbMovieContext.Date = movie.Date;
            dbMovieContext.Descricao = movie.Descricao;
            dbMovieContext.Duration = movie.Duration;
            dbMovieContext.ImageUrl = movie.ImageUrl;
            dbMovieContext.Name = movie.Name;

         }

         _dbContext.SaveChanges();
         
         return RedirectToAction("Movies");
      }


      public ActionResult Delete(int id) {

         var movie = _dbContext.Movies.Find(id);

         if (movie != null) {

            _dbContext.Movies.Remove(movie);
            _dbContext.SaveChanges();

         }

         return RedirectToAction("Movies");

      }






      /* 

          Overrides 

      */
      protected override void Dispose(bool disposing) {
         _dbContext.Dispose();
      }

   }
}
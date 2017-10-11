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

         var movie = this._dbContext.Movies.ToList().Find(predicted => predicted.Id == id);

         if (movie == null) return HttpNotFound();

         return View(movie);

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



      [HttpPost] // Will be access just with POST method
      public ActionResult Save(Movie movie) {

         if (movie.Id == 0) {
            this._dbContext.Movies.Add(movie);
         }
         else {
            this._dbContext.Entry(movie).State = EntityState.Modified;
         }

         this._dbContext.SaveChanges();

         return RedirectToAction("Movies");
      }


      public ActionResult Delete(int id) {

         var movie = this._dbContext.Movies.Find(id);

         if (movie != null) {

            this._dbContext.Movies.Remove(movie);
            this._dbContext.SaveChanges();

         }

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
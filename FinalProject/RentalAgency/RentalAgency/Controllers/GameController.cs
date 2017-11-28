using RentalAgency.Models;
using RentalAgency.ViewModels;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace RentalAgency.Controllers {

   public class GameController : Controller {




      /* 

          Propriedades da classe 

      */
      private ApplicationDbContext _dbContext = new ApplicationDbContext();





      /* 

          Construtores 

      */
      public GameController() {
         _dbContext.Games.Include(m => m.Category).ToList();
      }





      /* 

          Action Results

      */

      [AllowAnonymous]
      public ActionResult HomePage() {

         ViewBag.Message = "Home page";

         return View();
      }

      public ActionResult Game() {

         var GameIndexView = new GameIndexViewModel() {
            Games = _dbContext.Games.ToList()
         };

         return View(GameIndexView.Games);
      }



      public ActionResult Details(int id) {

         var Game = _dbContext.Games.ToList().Find(predicted => predicted.Id == id);

         if (Game == null) return HttpNotFound();

         return View(Game);

      }







      /* 

          CRUD Actions

      */
      public ActionResult Edit(int id) {

         var Game = _dbContext.Games.SingleOrDefault(m => m.Id == id);

         if (Game == null)
            return HttpNotFound();


         var GameViewModel = new GameFormViewModel() {
            Game = Game,
            Categories = _dbContext.Category.ToList()
         };


         return View("FormGame", GameViewModel);

      }



      public ActionResult New() {

         var GameViewModel = new GameFormViewModel() {
            Categories = _dbContext.Category.ToList()
         };

         ViewBag.CategoryId = new SelectList(_dbContext.Category, "Id", "CategoryName");
         return View("FormGame", GameViewModel);

      }



      [HttpPost] // Will be access just with POST method
      [ValidateAntiForgeryToken]
      public ActionResult Save(Game Game) {

         ModelState.Remove("Game.Id");
         ModelState.Remove("Game.CategoryId");
         if (!ModelState.IsValid) {

            var viewModel = new GameFormViewModel {
               Game = Game,
               Categories = _dbContext.Category.ToList()
            };

            return View("FormGame", viewModel);
         }

         if (Game.Id == 0) {

            _dbContext.Games.Add(Game);

         }
         else {

            Game dbGameContext = _dbContext.Games.Single(m => m.Id == Game.Id);

            dbGameContext.CategoryId = Game.CategoryId;
            dbGameContext.Date = Game.Date;
            dbGameContext.Descricao = Game.Descricao;
            dbGameContext.ImageUrl = Game.ImageUrl;
            dbGameContext.Name = Game.Name;

         }

         _dbContext.SaveChanges();

         return RedirectToAction("Game");
      }


      public ActionResult Delete(int id) {

         var Game = _dbContext.Games.Find(id);

         if (Game != null) {

            _dbContext.Games.Remove(Game);
            _dbContext.SaveChanges();

         }

         return RedirectToAction("Game");

      }






      /* 

          Overrides 

      */
      protected override void Dispose(bool disposing) {
         _dbContext.Dispose();
      }

   }
}
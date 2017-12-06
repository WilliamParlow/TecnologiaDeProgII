using RentalAgency.Models;
using RentalAgency.ViewModels;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace RentalAgency.Controllers {

   public class CostumerController : Controller {




      /* 

          Propriedades da classe 

      */
      private ApplicationDbContext _dbContext = new ApplicationDbContext();





      /* 

          Construtores 

      */
      public CostumerController() {
         _dbContext.Costumers.Include(c => c.MembershipType).ToList();
      }





      /* 

          Action Results

      */

      public ActionResult Costumer() {

         var CostumerIndexView = new CostumerIndexViewModel() {
            Costumers = _dbContext.Costumers.ToList()
         };

         return View(CostumerIndexView.Costumers);
      }



      public ActionResult Details(int id) {

         var Costumer = _dbContext.Costumers.ToList().Find(predicted => predicted.Id == id);

         if (Costumer == null) return HttpNotFound();

         return View(Costumer);

      }







      /* 

          CRUD Actions

      */
      public ActionResult Edit(int id) {

         var Costumer = _dbContext.Costumers.SingleOrDefault(m => m.Id == id);

         if (Costumer == null)
            return HttpNotFound();


         var CostumerViewModel = new CostumerFormViewModel() {
            Costumer = Costumer,
            MembershipTypes = _dbContext.MembershipTypes.ToList()
         };


         return View("FormCostumer", CostumerViewModel);

      }



      public ActionResult New() {

         var CostumerViewModel = new CostumerFormViewModel {
            MembershipTypes = _dbContext.MembershipTypes.ToList()
         };

         ViewBag.CategoryId = new SelectList(_dbContext.Category, "Id", "CategoryName");
         return View("FormCostumer", CostumerViewModel);

      }



      [HttpPost] // Will be access just with POST method
      [ValidateAntiForgeryToken]
      public ActionResult Save(Costumer Costumer) {

         ModelState.Remove("Costumer.Id");
         if (!ModelState.IsValid) {

            var viewModel = new CostumerFormViewModel {
               Costumer = Costumer
            };

            return View("FormCostumer", viewModel);
         }

         if (Costumer.Id == 0) {

            _dbContext.Costumers.Add(Costumer);

         }
         else {

            Costumer dbCostumerContext = _dbContext.Costumers.Single(m => m.Id == Costumer.Id);

            dbCostumerContext.Name = Costumer.Name;
            dbCostumerContext.Email = Costumer.Email;
            dbCostumerContext.IsSubscribedToNewsletter = Costumer.IsSubscribedToNewsletter;
            dbCostumerContext.MembershipTypeId = Costumer.MembershipTypeId;
            dbCostumerContext.canEdit = Costumer.canEdit;
            dbCostumerContext.ImageUrl = Costumer.ImageUrl;

         }

         _dbContext.SaveChanges();

         return RedirectToAction("Costumer");
      }


      public ActionResult Delete(int id) {

         var Costumer = _dbContext.Costumers.Find(id);

         if (Costumer != null) {

            _dbContext.Costumers.Remove(Costumer);
            _dbContext.SaveChanges();

         }

         return RedirectToAction("Costumer");

      }






      /* 

          Overrides 

      */
      protected override void Dispose(bool disposing) {
         _dbContext.Dispose();
      }

   }
}
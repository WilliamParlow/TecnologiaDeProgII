using RentalAgency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentalAgency.ViewModels {
   public class GameFormViewModel {

      public Game Game;
      public IEnumerable<Category> Categories;
      public string Title {

         get {

            if (this.Game != null && this.Game.Id != 0)
               return "Edit Game";

            return "New Game";

         }

      }

   }

}
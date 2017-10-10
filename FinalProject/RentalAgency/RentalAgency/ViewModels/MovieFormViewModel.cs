using RentalAgency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentalAgency.ViewModels {
   public class MovieFormViewModel {

      public Movie Movie;
      public string Title {

         get {

            if (this.Movie != null && this.Movie.Id != 0)
               return "Edit Movie";

            return "New Movie";

         }

      }

   }

}
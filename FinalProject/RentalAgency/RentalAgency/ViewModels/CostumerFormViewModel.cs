using RentalAgency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentalAgency.ViewModels {
   public class CostumerFormViewModel {

      public Costumer Costumer;
      public IEnumerable<MembershipType> MembershipTypes;
      public string Title {

         get {

            if (this.Costumer != null && this.Costumer.Id != 0)
               return "Edit Costumer";

            return "New Costumer";

         }

      }

   }

}
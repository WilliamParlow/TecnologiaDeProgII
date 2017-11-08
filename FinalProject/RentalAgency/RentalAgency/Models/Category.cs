using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentalAgency.Models {
   public class Category {

      
      public int Id { get; set; }
      [Required]
      [MaxLength(255)]
      [Display(Name = "Tipo de categoria")]
      public String CategoryName { get; set; }

   }
}
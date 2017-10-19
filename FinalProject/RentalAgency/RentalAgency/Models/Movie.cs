using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentalAgency.Models {
   public class Movie {

      public int Id { get; set; }
      [Required]
      [MaxLength(255)]
      [Display(Name = "Nome")]
      public string Name { get; set; }
      [Required]
      [Display(Name = "Gênero")]
      public string Genre { get; set; }
      [Required]
      [Display(Name = "Duração")]
      [Range(0, int.MaxValue)]
      public int Duration { get; set; }
      [Display(Name = "Selecione uma imagem")]
      public string ImageUrl { get; set; }
      [Required]
      [Display(Name = "Descrição")]
      public string Descricao { get; set; }


   }

}
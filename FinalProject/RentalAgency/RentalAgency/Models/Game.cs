using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RentalAgency.Models {
   public class Game {

      public int Id { get; set; }

      [Required(ErrorMessage = "Campo nome é obrigatório")]
      [MaxLength(255)]
      [Display(Name = "Nome")]
      public string Name { get; set; }

      [Display(Name = "Categoria")]
      [ForeignKey("CategoryId")]
      public Category Category { get; set; }

      [Required(ErrorMessage = "Selecionar uma categoria é obrigatório")]
      [Display(Name = "Categoria")]
      public int CategoryId { get; set; }

      [Display(Name = "Selecione uma imagem")]
      public string ImageUrl { get; set; }

      [Required(ErrorMessage = "Descrição para o jogo é obrigatório")]
      [Display(Name = "Descrição")]
      public string Descricao { get; set; }

      [Required(ErrorMessage = "Data de lançamento é obrigatório")]
      [Display(Name = "Data de lançamento")]
      [DataType(DataType.Date)]
      [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
      public DateTime Date { get; set; }

   }
}
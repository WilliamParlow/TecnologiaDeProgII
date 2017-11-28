using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RentalAgency.Models {
   public class Costumer {

      public int Id { get; set; }

      [Required(ErrorMessage = "Campo nome é obrigatório")]
      [MaxLength(255)]
      [Display(Name = "Nome")]
      public string Name { get; set; }

      [Required(ErrorMessage = "Campo Email é obrigatório")]
      [MaxLength(255)]
      [Display(Name = "Email")]
      public string Email { get; set; }

      [Required(ErrorMessage = "Selecionar um usuário é obrigatório")]
      [Display(Name = "Usuário")]
      public string UserID { get; set; }

      [Display(Name = "Inscrever para receber notícias")]
      public bool IsSubscribedToNewsletter { get; set; }

      [Display(Name = "Membro do usuário")]
      [ForeignKey("MembershipTypeId")]
      public MembershipType MembershipType { get; set; }

      [Required(ErrorMessage = "Selecionar um membro é obrigatório")]
      [Display(Name = "Usuário")]
      public byte MembershipTypeId { get; set; }

   }
}
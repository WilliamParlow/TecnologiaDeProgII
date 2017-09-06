using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentalAgency.Models {
    public class Rental {

        public int Id { get; set; }
        public string MovieName { get; set; }
        public int RentalDays { get; set; }
        public double Price { get; set; }

    }

}
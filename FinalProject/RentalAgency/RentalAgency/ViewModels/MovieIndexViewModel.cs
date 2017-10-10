using RentalAgency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentalAgency.ViewModels {
    public class MovieIndexViewModel {

        public IEnumerable<Movie> Movies { get; set; }

    }
}
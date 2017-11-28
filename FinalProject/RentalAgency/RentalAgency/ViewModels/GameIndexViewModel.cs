using RentalAgency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentalAgency.ViewModels {
    public class GameIndexViewModel {

        public IEnumerable<Game> Games { get; set; }

    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentalAgency.Models {
    public class Movie {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; }
        public string ImageUrl { get; set; }
        public string Descricao { get; set; }


    }

}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentalAgency.Models;

namespace RentalAgency.Controllers {
    public class MovieController : Controller {

        List<Movie> movies = new List<Movie>(){
            new Movie() { Name = "Shrek!", Id = 1, Duration = 180, Genre = "Comedy", ImageUrl = "http://t2.gstatic.com/images?q=tbn:ANd9GcS_OkJKQ6ZpDV_xhC0L9zyHEcKMlV9x3Q30LF6MOE0nV1U6r09p", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce diam massa, suscipit eu lectus ac, ultrices rutrum diam. Aenean accumsan neque eu risus pellentesque ultrices. Sed ac lectus sagittis, ultricies ex sed, vehicula purus. Proin facilisis maximus viverra. Aliquam ac scelerisque risus. Suspendisse ac facilisis eros."},
            new Movie() { Name = "IT", Id = 2, Duration = 173, Genre = "Horror", ImageUrl = "http://br.web.img2.acsta.net/pictures/17/03/29/07/56/333222.jpg", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce diam massa, suscipit eu lectus ac, ultrices rutrum diam. Aenean accumsan neque eu risus pellentesque ultrices. Sed ac lectus sagittis, ultricies ex sed, vehicula purus. Proin facilisis maximus viverra. Aliquam ac scelerisque risus. Suspendisse ac facilisis eros." },
            new Movie() { Name = "The sect", Id = 3, Duration = 130, Genre = "Horror", ImageUrl = "https://images-na.ssl-images-amazon.com/images/M/MV5BN2Y2MjQ3ODEtYjI0MS00ODc2LThkZmQtYTcwODRjYTg5YWJkL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyMTYxNjkxOQ@@._V1_UY1200_CR104,0,630,1200_AL_.jpg", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce diam massa, suscipit eu lectus ac, ultrices rutrum diam. Aenean accumsan neque eu risus pellentesque ultrices. Sed ac lectus sagittis, ultricies ex sed, vehicula purus. Proin facilisis maximus viverra. Aliquam ac scelerisque risus. Suspendisse ac facilisis eros." },
            new Movie() { Name = "Exorcism of Emily Rose", Id = 4, Duration = 160, Genre = "Horror", ImageUrl = "https://upload.wikimedia.org/wikipedia/pt/b/b3/The_Exorcism_of_Emily_Rose.jpg", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce diam massa, suscipit eu lectus ac, ultrices rutrum diam. Aenean accumsan neque eu risus pellentesque ultrices. Sed ac lectus sagittis, ultricies ex sed, vehicula purus. Proin facilisis maximus viverra. Aliquam ac scelerisque risus. Suspendisse ac facilisis eros." },
            new Movie() { Name = "OUIJA", Id = 5, Duration = 162, Genre = "Horror", ImageUrl = "http://br.web.img2.acsta.net/c_215_290/pictures/14/11/25/16/14/535714.jpg", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce diam massa, suscipit eu lectus ac, ultrices rutrum diam. Aenean accumsan neque eu risus pellentesque ultrices. Sed ac lectus sagittis, ultricies ex sed, vehicula purus. Proin facilisis maximus viverra. Aliquam ac scelerisque risus. Suspendisse ac facilisis eros." },
            new Movie() { Name = "Paranormal Activity", Id = 6, Duration = 123, Genre = "Horror", ImageUrl = "https://upload.wikimedia.org/wikipedia/pt/5/54/Paranormal_Activity_poster.jpg", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce diam massa, suscipit eu lectus ac, ultrices rutrum diam. Aenean accumsan neque eu risus pellentesque ultrices. Sed ac lectus sagittis, ultricies ex sed, vehicula purus. Proin facilisis maximus viverra. Aliquam ac scelerisque risus. Suspendisse ac facilisis eros." },
            new Movie() { Name = "The witch", Id = 7, Duration = 133, Genre = "Horror", ImageUrl = "https://2tax3i7eqir13il3d49l65b3-wpengine.netdna-ssl.com/wp-content/uploads/2016/02/witch_ver4.jpg", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce diam massa, suscipit eu lectus ac, ultrices rutrum diam. Aenean accumsan neque eu risus pellentesque ultrices. Sed ac lectus sagittis, ultricies ex sed, vehicula purus. Proin facilisis maximus viverra. Aliquam ac scelerisque risus. Suspendisse ac facilisis eros." },
            new Movie() { Name = "Friday 13", Id = 8, Duration = 125, Genre = "Horror", ImageUrl = "https://vignette1.wikia.nocookie.net/egamia/images/7/7b/Friday_the_13th.jpeg/revision/latest?cb=20160514005545", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce diam massa, suscipit eu lectus ac, ultrices rutrum diam. Aenean accumsan neque eu risus pellentesque ultrices. Sed ac lectus sagittis, ultricies ex sed, vehicula purus. Proin facilisis maximus viverra. Aliquam ac scelerisque risus. Suspendisse ac facilisis eros." },
            new Movie() { Name = "Shrek!", Id = 9, Duration = 180, Genre = "Comedy", ImageUrl = "http://t2.gstatic.com/images?q=tbn:ANd9GcS_OkJKQ6ZpDV_xhC0L9zyHEcKMlV9x3Q30LF6MOE0nV1U6r09p", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce diam massa, suscipit eu lectus ac, ultrices rutrum diam. Aenean accumsan neque eu risus pellentesque ultrices. Sed ac lectus sagittis, ultricies ex sed, vehicula purus. Proin facilisis maximus viverra. Aliquam ac scelerisque risus. Suspendisse ac facilisis eros."},
            new Movie() { Name = "IT", Id = 10, Duration = 173, Genre = "Horror", ImageUrl = "http://br.web.img2.acsta.net/pictures/17/03/29/07/56/333222.jpg", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce diam massa, suscipit eu lectus ac, ultrices rutrum diam. Aenean accumsan neque eu risus pellentesque ultrices. Sed ac lectus sagittis, ultricies ex sed, vehicula purus. Proin facilisis maximus viverra. Aliquam ac scelerisque risus. Suspendisse ac facilisis eros." },
            new Movie() { Name = "The sect", Id = 11, Duration = 130, Genre = "Horror", ImageUrl = "https://images-na.ssl-images-amazon.com/images/M/MV5BN2Y2MjQ3ODEtYjI0MS00ODc2LThkZmQtYTcwODRjYTg5YWJkL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyMTYxNjkxOQ@@._V1_UY1200_CR104,0,630,1200_AL_.jpg", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce diam massa, suscipit eu lectus ac, ultrices rutrum diam. Aenean accumsan neque eu risus pellentesque ultrices. Sed ac lectus sagittis, ultricies ex sed, vehicula purus. Proin facilisis maximus viverra. Aliquam ac scelerisque risus. Suspendisse ac facilisis eros." },
            new Movie() { Name = "Exorcism of Emily Rose", Id = 12, Duration = 160, Genre = "Horror", ImageUrl = "https://upload.wikimedia.org/wikipedia/pt/b/b3/The_Exorcism_of_Emily_Rose.jpg", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce diam massa, suscipit eu lectus ac, ultrices rutrum diam. Aenean accumsan neque eu risus pellentesque ultrices. Sed ac lectus sagittis, ultricies ex sed, vehicula purus. Proin facilisis maximus viverra. Aliquam ac scelerisque risus. Suspendisse ac facilisis eros." },
            new Movie() { Name = "OUIJA", Id = 13, Duration = 162, Genre = "Horror", ImageUrl = "http://br.web.img2.acsta.net/c_215_290/pictures/14/11/25/16/14/535714.jpg", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce diam massa, suscipit eu lectus ac, ultrices rutrum diam. Aenean accumsan neque eu risus pellentesque ultrices. Sed ac lectus sagittis, ultricies ex sed, vehicula purus. Proin facilisis maximus viverra. Aliquam ac scelerisque risus. Suspendisse ac facilisis eros." },
            new Movie() { Name = "Paranormal Activity", Id = 14, Duration = 123, Genre = "Horror", ImageUrl = "https://upload.wikimedia.org/wikipedia/pt/5/54/Paranormal_Activity_poster.jpg", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce diam massa, suscipit eu lectus ac, ultrices rutrum diam. Aenean accumsan neque eu risus pellentesque ultrices. Sed ac lectus sagittis, ultricies ex sed, vehicula purus. Proin facilisis maximus viverra. Aliquam ac scelerisque risus. Suspendisse ac facilisis eros." },
            new Movie() { Name = "The witch", Id = 15, Duration = 133, Genre = "Horror", ImageUrl = "https://2tax3i7eqir13il3d49l65b3-wpengine.netdna-ssl.com/wp-content/uploads/2016/02/witch_ver4.jpg", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce diam massa, suscipit eu lectus ac, ultrices rutrum diam. Aenean accumsan neque eu risus pellentesque ultrices. Sed ac lectus sagittis, ultricies ex sed, vehicula purus. Proin facilisis maximus viverra. Aliquam ac scelerisque risus. Suspendisse ac facilisis eros." },
            new Movie() { Name = "Friday 13", Id = 16, Duration = 125, Genre = "Horror", ImageUrl = "https://vignette1.wikia.nocookie.net/egamia/images/7/7b/Friday_the_13th.jpeg/revision/latest?cb=20160514005545", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce diam massa, suscipit eu lectus ac, ultrices rutrum diam. Aenean accumsan neque eu risus pellentesque ultrices. Sed ac lectus sagittis, ultricies ex sed, vehicula purus. Proin facilisis maximus viverra. Aliquam ac scelerisque risus. Suspendisse ac facilisis eros." },
            new Movie() { Name = "The witch", Id = 17, Duration = 133, Genre = "Horror", ImageUrl = "https://2tax3i7eqir13il3d49l65b3-wpengine.netdna-ssl.com/wp-content/uploads/2016/02/witch_ver4.jpg", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce diam massa, suscipit eu lectus ac, ultrices rutrum diam. Aenean accumsan neque eu risus pellentesque ultrices. Sed ac lectus sagittis, ultricies ex sed, vehicula purus. Proin facilisis maximus viverra. Aliquam ac scelerisque risus. Suspendisse ac facilisis eros." },
            new Movie() { Name = "Friday 13", Id = 18, Duration = 125, Genre = "Horror", ImageUrl = "https://vignette1.wikia.nocookie.net/egamia/images/7/7b/Friday_the_13th.jpeg/revision/latest?cb=20160514005545", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce diam massa, suscipit eu lectus ac, ultrices rutrum diam. Aenean accumsan neque eu risus pellentesque ultrices. Sed ac lectus sagittis, ultricies ex sed, vehicula purus. Proin facilisis maximus viverra. Aliquam ac scelerisque risus. Suspendisse ac facilisis eros." }
        };

        public ActionResult HomePage() {

            ViewBag.Message = "Home page";

            return View();
        }

        public ActionResult Movies() {

            

            
            return View(movies);
        }

        public ActionResult Details(int id) {

            if (id > movies.Count) return HttpNotFound();

            return View(movies.Find(predicted => predicted.Id == id));

        }

    }
}
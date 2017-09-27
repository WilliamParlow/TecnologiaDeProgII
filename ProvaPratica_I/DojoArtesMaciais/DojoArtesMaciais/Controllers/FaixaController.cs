using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DojoArtesMaciais.Models;

namespace DojoArtesMaciais.Controllers
{
    public class FaixaController : Controller
    {
        private ApplicationDbContext _context;

        public FaixaController() {

            this._context = new ApplicationDbContext();

        }

        // GET: Faixa
        public ActionResult Index() {
            var listaFaixas = this._context.Faixa.ToList();

            return View(listaFaixas);
        }

        public ActionResult Details(int id) {

            var listaFaixas = this._context.Faixa.ToList();

            return View(listaFaixas.Find(faixa => faixa.Id == id));

        }
    }
}
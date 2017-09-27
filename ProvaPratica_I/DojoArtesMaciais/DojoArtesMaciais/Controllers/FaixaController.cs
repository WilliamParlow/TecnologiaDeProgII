using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DojoArtesMaciais.Models;

/* 
 * Autor: William Parlow Nichelatti
 * Email: william.nichelatti@catolicasc.org.br
 */

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

            Faixa faixaDetails = listaFaixas.Find(faixa => faixa.Id == id);

            if (faixaDetails == null) return HttpNotFound();

            return View(faixaDetails);

        }
    }
}
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
    public class TipoDeAssociacaoController : Controller
    {
        private ApplicationDbContext _context;

        public TipoDeAssociacaoController() {

            this._context = new ApplicationDbContext();

        }

        // GET: TipoDeAssociacao
        public ActionResult Index() {
            var listaTipoAssociacao = this._context.TipoDeAssociacao.ToList();

            return View(listaTipoAssociacao);
        }

        public ActionResult Details(int id) {

            var listaTipoAssociacao = this._context.TipoDeAssociacao.ToList();

            return View(listaTipoAssociacao.Find(tipoAssociacao => tipoAssociacao.Id == id));

        }
    }
}
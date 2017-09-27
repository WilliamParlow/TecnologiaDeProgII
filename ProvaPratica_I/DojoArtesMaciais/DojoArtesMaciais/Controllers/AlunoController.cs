using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using DojoArtesMaciais.Models;

namespace DojoArtesMaciais.Controllers
{
    public class AlunoController : Controller
    {

        private ApplicationDbContext _context;

        public AlunoController() {

            this._context = new ApplicationDbContext();
            this._context.Aluno.Include(e => e.TipoDeAssociacao).ToList();
            this._context.Aluno.Include(e => e.Faixa).ToList();

        }

        // GET: Aluno
        public ActionResult Index()
        {
            var listaAlunos = this._context.Aluno.ToList();

            return View(listaAlunos);
        }

        public ActionResult Details(int id) {

            var listaAlunos = this._context.Aluno.ToList();

            return View(listaAlunos.Find(aluno => aluno.Id == id));

        }
    }
}
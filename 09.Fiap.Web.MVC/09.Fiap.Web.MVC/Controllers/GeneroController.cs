using _09.Fiap.Web.MVC.Models;
using _09.Fiap.Web.MVC.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _09.Fiap.Web.MVC.Controllers
{
    public class GeneroController : Controller
    {

        private UnitOfWork _unit = new UnitOfWork();

       [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Genero genero)
        {
            _unit.GeneroRepository.Cadastrar(genero);
            _unit.Salvar();
            TempData["msg"] = "Genero Cadastrado com sucesso!";
            return RedirectToAction("Cadastrar");
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}
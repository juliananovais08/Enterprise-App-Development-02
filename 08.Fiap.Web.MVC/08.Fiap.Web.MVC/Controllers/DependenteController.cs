using _08.Fiap.Web.MVC.Models;
using _08.Fiap.Web.MVC.Units;
using _08.Fiap.Web.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _08.Fiap.Web.MVC.Controllers
{
    public class DependenteController : Controller
    {

        private UnitOfWork _unit = new UnitOfWork();
        // GET: Dependente
        [HttpGet]
        public ActionResult Cadastrar()
        {
            var viewModel = new DependenteViewModel();
            var lista = _unit.ResponsavelRepository.Listar(); //pra fazer o select e trazer o responsável
            ViewBag.responsaveis = new SelectList(lista, "ResponsavelId", "Nome");
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Cadastrar(Dependente dependente)
        {
            _unit.DependenteRepository.Cadastrar(dependente);
            _unit.Salvar();
            TempData["msg"] = "Dependente cadastrado!";
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public ActionResult Listar()
        {

            return View(_unit.DependenteRepository.listar());
        }

        //override Dis
        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}
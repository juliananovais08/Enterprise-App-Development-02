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
    public class ResponsavelController : Controller

    {
        private UnitOfWork _unit = new UnitOfWork();
        // GET: Responsavel
        [HttpGet]
        public ActionResult Cadastrar()
        {
            var viewModel = new ResponsavelViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Cadastrar(Responsavel responsavel)
        {
            
            _unit.ResponsavelRepository.Cadastrar(responsavel);
            _unit.Salvar();
            TempData["msg"] = "Responsavel cadastrado!";
            return RedirectToAction("Cadastrar");
        }

        //Liberar os recursos (conexão com o banco)
        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing); //quer distruir a minha parte e pare do pai
        }
    }
}
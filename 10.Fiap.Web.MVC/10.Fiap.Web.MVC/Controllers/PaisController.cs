using _10.Fiap.Web.MVC.Models;
using _10.Fiap.Web.MVC.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _10.Fiap.Web.MVC.Controllers
{
    public class PaisController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();  //PRIVATE

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Pais pais)
        {
            _unit.PaisRepository.Cadastrar(pais);  //CAP 08 - UNIT
            _unit.Save();
            TempData["msg"] = "País Cadastrado com sucesso!";  //CAP 03
            return RedirectToAction("Cadastrar");
        }

        protected override void Dispose(bool disposing) //CAP 08 - UNIT
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}
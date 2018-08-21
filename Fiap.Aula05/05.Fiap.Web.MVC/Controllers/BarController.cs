using _05.Fiap.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _05.Fiap.Web.MVC.Controllers
{
    public class BarController : Controller
    {

        private static List<Bar> _lista = new List<Bar>();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            List<string> cidades = new List<string>();
            cidades.Add("São Paulo");
            cidades.Add("Rio de Janeiro");
            cidades.Add("Curitiba");
            // Enviar apara a pagina a lista de cidades para o select
            ViewBag.listaCidades = new SelectList(cidades);
            return View();
        }

        public ActionResult Listar()
        {
            return View(_lista);
        }

        [HttpPost]
        public ActionResult Cadastrar(Bar bar)
        {
            _lista.Add(bar);
            TempData["msg"] = "Bar Cadastrado"; //Exibe na prox página após o redirect
            return RedirectToAction("Cadastrar");
        }
    }
}
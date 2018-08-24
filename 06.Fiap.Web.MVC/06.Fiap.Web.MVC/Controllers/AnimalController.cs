using _06.Fiap.Web.MVC.Models;
using _06.Fiap.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _06.Fiap.Web.MVC.Controllers
{
    public class AnimalController : Controller
    {

        private PetshopContext _contex = new PetshopContext();
        // GET: Animal
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Animal animal)
        {

            return RedirectToAction("Cadastrar");
        }
    }
}
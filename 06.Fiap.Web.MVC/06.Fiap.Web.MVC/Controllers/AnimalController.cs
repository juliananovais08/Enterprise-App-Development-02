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

        private static List<Animal> _lista = new List<Animal>();

        private PetshopContext _contex = new PetshopContext();
        // GET: Animal
        [HttpGet]
        public ActionResult Cadastrar()
        {
            
            return View();
        }

        [HttpGet]
        public ActionResult Listar()
        {
            //Recupera os animais cadastrados no banco
            var lista = _contex.Animais.ToList();
            //Retorna a tela com a lista de animais
            return View(lista);
        }

        [HttpGet]
        public ActionResult Alterar(int id)
        {
            //buscar o animal no banco de dados
            var animal = _contex.Animais.Find(id);
            //retorna a página com os dados do animal
            return View(animal);
        }

        public ActionResult Alterar(Animal animal)
        {
            _contex.Entry(animal).State = System.Data.Entity.EntityState.Modified;
            _contex.SaveChanges();
            TempData["msg"] = "Animal atualizado";
            return RedirectToAction("listar");
        }

        [HttpPost]
        public ActionResult Cadastrar(Animal animal)
        {
            _contex.Animais.Add(animal);
            _contex.SaveChanges();
            TempData["msg"] = "Cadastrado com sucesso!";
            return RedirectToAction("Cadastrar");
        }
    }
}
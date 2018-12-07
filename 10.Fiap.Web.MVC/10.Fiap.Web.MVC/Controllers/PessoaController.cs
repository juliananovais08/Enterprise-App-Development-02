using _10.Fiap.Web.MVC.Models;
using _10.Fiap.Web.MVC.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _10.Fiap.Web.MVC.Controllers
{
    public class PessoaController : Controller
    {
        //CAPITULO 03, 04 e 08

        private UnitOfWork _unit = new UnitOfWork(); //PRIVATE

        private void CarregarSelectPaises() //VAI  CARREGAR UM SELECT COM OS PAISES (NO GET)
        {
            var lista = _unit.PaisRepository.Listar();  //var para listar os paises
            ViewBag.paises = new SelectList(lista, "PaisId", "Nome"); //CAPITULO 04
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            CarregarSelectPaises(); //AO ABRIR O CADASTRAR VAI TER O SELECT DE PAISES
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Pessoa pessoa)
        {
            _unit.PessoaRepository.Cadastrar(pessoa);
            _unit.Save();
            TempData["msg"] = "Pessoa cadastrada com sucesso!";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Listar()
        {
            CarregarSelectPaises(); //CARREGAR OS PAISES NA LISTA
            var lista = _unit.PessoaRepository.Listar();
            return View(lista); 
        }

      

        [HttpGet]
        public ActionResult Editar(int id)  //IMPORTANTE
        {
            CarregarSelectPaises();
            var pessoa = _unit.PessoaRepository.Buscar(id);
            return View(pessoa); //A View EDITAR mas com a pessoa especifica pelo ID
        }

        [HttpPost]
        public ActionResult Editar(Pessoa pessoa)
        {
            _unit.PessoaRepository.Atualizar(pessoa);
            _unit.Save();
            TempData["msg"] = "Pessoa atualizada com sucesso!";
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Remover(int codigo)
        {
            _unit.PessoaRepository.Remover(codigo);
            _unit.Save();
            TempData["msg"] = "Pessoa removida com sucesso!";
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Validar(int codigo)
        {
            var pessoa = _unit.PessoaRepository.Buscar(codigo); // var para buscar
            pessoa.Valido = true;

            _unit.PessoaRepository.Atualizar(pessoa);
            _unit.Save();
            TempData["msg"] = "Pessoa validada com sucesso!";
            return RedirectToAction("Listar");
        }

         [HttpGet]
         public ActionResult BuscarPorNome(string nome)
        {
            var lista = _unit.PessoaRepository.BuscarPor(p => p.Nome.Contains(nome)); // CAPITULO 08  p => p.Nome == nome
            CarregarSelectPaises(); //vai trazer os paises
            return View("Listar", lista);
        }

        [HttpGet]
        public ActionResult BuscarPorPais(int paisId)
        {
            var lista = _unit.PessoaRepository.BuscarPor(p => p.PaisId == paisId); //CAPITULO 08
            CarregarSelectPaises(); //Traz os paisses
            return View("Listar", lista);
        }


        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}
using _11.Fiap.Web.MVC.Models;
using _11.Fiap.Web.MVC.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _11.Fiap.Web.MVC.Controllers
{
    public class FilmeController : Controller
    {
        UnitOfWork _unit = new UnitOfWork();

        private void CarregarSelectGenero()
        {
            var lista = _unit.GeneroRepository.Listar();
            ViewBag.Generos = new SelectList(lista, "GeneroId", "Nome");
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            CarregarSelectGenero();
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Filme filme)
        {
            _unit.FilmeRepository.Cadastrar(filme);
            _unit.Save();
            TempData["msg"] = "Filme cadastrado com sucesso!";
            return RedirectToAction("Cadastrar");
        } 

        [HttpGet]
        public ActionResult Listar()
        {
            CarregarSelectGenero();
            var lista = _unit.FilmeRepository.Listar();
            return View(lista);
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            CarregarSelectGenero();
            var filme = _unit.FilmeRepository.Buscar(id);
            return View(filme);
        }

        [HttpPost]
        public ActionResult Editar(Filme filme)
        {
            _unit.FilmeRepository.Atualizar(filme);
            _unit.Save();
            TempData["msg"] = "Filme atualizado com sucesso!";
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Remover(int codigo)
        {
            _unit.FilmeRepository.Remover(codigo);
            _unit.Save();
            TempData["msg"] = "Filme removido com sucesso!";
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Disponibilizar(int codigo)
        {
            var filme = _unit.FilmeRepository.Buscar(codigo);
            filme.Disponivel = true;

            _unit.FilmeRepository.Atualizar(filme);
            _unit.Save();
            TempData["msg"] = "Filme disponível!";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult BuscarPorNome(string nome)
        {
            CarregarSelectGenero();
            var lista = _unit.FilmeRepository.BuscarPor(f => f.Nome.Contains(nome));
            return View(lista);
        }

        [HttpGet]
        public ActionResult BuscarPorGenero(int generoId)
        {
            CarregarSelectGenero();
            var lista = _unit.FilmeRepository.BuscarPor(f => f.GeneroId == generoId);
            return View(lista);
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}
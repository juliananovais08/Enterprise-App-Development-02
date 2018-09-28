using _08.Fiap.Web.MVC.Units;
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
        public ActionResult Cadastrar()
        {
            return View();
        }

        //Liberar os recursos (conexão com o banco)
        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}
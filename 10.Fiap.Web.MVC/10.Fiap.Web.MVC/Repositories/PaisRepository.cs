using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _10.Fiap.Web.MVC.Models;
using _10.Fiap.Web.MVC.Persistencia;

namespace _10.Fiap.Web.MVC.Repositories
{
    public class PaisRepository : IPaisRepository
    {
        //CAPITULO 08

        private PassaporteContext _context;

        public PaisRepository(PassaporteContext context)  //CONSTRUTOR QUE VEM PELO UNIT OF WORK
        {
            _context = context;
        }

        public void Cadastrar(Pais pais)
        {
            _context.Paises.Add(pais);
        }

        public IList<Pais> Listar()
        {
            return _context.Paises.ToList();
        }
    }
}
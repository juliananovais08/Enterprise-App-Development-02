using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _11.Fiap.Web.MVC.Models;
using _11.Fiap.Web.MVC.Persistencia;

namespace _11.Fiap.Web.MVC.Units
{
    public class GeneroRepository : IGeneroRepository
    {
        private LocadoraContext _context;

        public GeneroRepository(LocadoraContext context)
        {
            _context = context;
        }

        public void Cadastrar(Genero genero)
        {
            _context.Generos.Add(genero);
        }

        public IList<Genero> Listar()
        {
            return _context.Generos.ToList();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _09.Fiap.Web.MVC.Models;
using _09.Fiap.Web.MVC.Persistencia;

namespace _09.Fiap.Web.MVC.Repositories
{
    public class GeneroRepository : IGeneroRepository
    {
        private GameContext _context;

        public GeneroRepository(GameContext context)
        {
            _context = context;
        }

        public void Cadastrar(Genero genero)
        {
            _context.Generos.Add(genero);
        }

        public IList<Genero> listar()
        {
            return _context.Generos.ToList();
        }
    }
}
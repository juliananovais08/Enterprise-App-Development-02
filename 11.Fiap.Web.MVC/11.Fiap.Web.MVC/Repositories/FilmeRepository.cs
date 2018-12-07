using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using _11.Fiap.Web.MVC.Models;
using _11.Fiap.Web.MVC.Persistencia;

namespace _11.Fiap.Web.MVC.Units
{
    public class FilmeRepository : IFilmeRepository
    {
        private LocadoraContext _context;

        public FilmeRepository(LocadoraContext context)
        {
            _context = context;
        }

        public void Atualizar(Filme filme)
        {
            _context.Entry(filme).State = EntityState.Modified;
        }

        public Filme Buscar(int filmeId)
        {
            return _context.Filmes.Find(filmeId);
        }

        public IList<Filme> BuscarPor(Expression<Func<Filme, bool>> filtro)
        {
            return _context.Filmes.Include("Genero").Where(filtro).ToList();
        }

        public void Cadastrar(Filme filme)
        {
            _context.Filmes.Add(filme);
        }

        public IList<Filme> Listar()
        {
            return _context.Filmes.ToList();
        }

        public void Remover(int filmeId)
        {
            Filme filme = _context.Filmes.Find(filmeId);
            _context.Filmes.Remove(filme);
        }
    }
}
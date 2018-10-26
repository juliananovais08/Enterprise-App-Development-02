using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using _09.Fiap.Web.MVC.Models;
using _09.Fiap.Web.MVC.Persistencia;

namespace _09.Fiap.Web.MVC.Repositories
{
    public class JogoRepository : IJogoRepository
    {

        private GameContext _context;

        public JogoRepository(GameContext context)
        {
            _context = context;
        }

        public void Atualizar(Jogo jogo)
        {
            _context.Entry(jogo).State = EntityState.Modified;  
        }

        public Jogo Buscar(int codigo)
        {
            return _context.Jogos.Find(codigo);
        }

        public IList<Jogo> BuscarPor(Expression<Func<Jogo, bool>> filtro)
        {
            return _context.Jogos.Where(filtro).ToList();
        }

        public void Cadastrar(Jogo jogo)
        {
            _context.Jogos.Add(jogo);
        }

        public IList<Jogo> listar()
        {
            return _context.Jogos.ToList();
        }

        public void Remover(int codigo)
        {
            var rem = Buscar(codigo);
            _context.Jogos.Remove(rem);
        }

    }
}
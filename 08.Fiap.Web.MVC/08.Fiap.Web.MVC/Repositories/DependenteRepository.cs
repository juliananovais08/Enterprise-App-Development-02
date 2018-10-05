using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using _08.Fiap.Web.MVC.Models;
using _08.Fiap.Web.MVC.Persistencia;

namespace _08.Fiap.Web.MVC.Repositories
{
    public class DependenteRepository : IDependenteRepository
    {

        private EscolaContext _context;

        public DependenteRepository(EscolaContext context)
        {
            _context = context;
        }

        public void Alterar(Dependente dependente)
        {
            _context.Entry(dependente).State = EntityState.Modified;
        }

        public Dependente Buscar(int codigo)
        {
            return _context.Dependentes.Find(codigo);
        }

        public IList<Dependente> BuscarPor(Expression<Func<Dependente, bool>> filtro)
        {
            return _context.Dependentes.Include("Responsavel").Where(filtro).ToList(); //INCLUDE PRA TRAZER O RESPONSAVEL NA PAGINA DE LISTAGEM
        }

        public void Cadastrar(Dependente dependente)
        {
            _context.Dependentes.Add(dependente);
        }

        public IList<Dependente> listar()
        {
            return _context.Dependentes.Include("Responsavel").ToList();
        }

        public void Remover(int codigo)
        {
            var rem = Buscar(codigo);
            _context.Dependentes.Remove(rem);
        }
    }
}
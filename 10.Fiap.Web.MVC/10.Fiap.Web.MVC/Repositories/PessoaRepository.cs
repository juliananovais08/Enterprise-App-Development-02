using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using _10.Fiap.Web.MVC.Models;
using _10.Fiap.Web.MVC.Persistencia;

namespace _10.Fiap.Web.MVC.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        //CAPITULO 08

        private PassaporteContext _context;

        public PessoaRepository(PassaporteContext context) //CONSTRUTOR QUE VEM PELO UNIT OF WORK
        {
            _context = context;
        }

        public void Atualizar(Pessoa pessoa)
        {
            _context.Entry(pessoa).State = EntityState.Modified;
        }

        public Pessoa Buscar(int pessoaId)
        {
            return _context.Pessoas.Find(pessoaId);
        }

        public IList<Pessoa> BuscarPor(Expression<Func<Pessoa, bool>> filtro)
        {
            return _context.Pessoas.Include("Pais").Where(filtro).ToList(); //////////INCLUDE PAIS
        }

        public void Cadastrar(Pessoa pessoa)
        {
            _context.Pessoas.Add(pessoa);
        }

        public IList<Pessoa> Listar()
        {
            return _context.Pessoas.ToList();
        }

        public void Remover(int pessoaId)
        {
            Pessoa pessoa = _context.Pessoas.Find(pessoaId);
            _context.Pessoas.Remove(pessoa);
        }
    }
}   
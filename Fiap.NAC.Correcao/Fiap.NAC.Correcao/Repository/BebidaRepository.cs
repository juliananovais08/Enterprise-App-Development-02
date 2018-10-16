using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Fiap.NAC.Correcao.Models;
using Fiap.NAC.Correcao.Persistencia;

namespace Fiap.NAC.Correcao.Repository
{
    public class BebidaRepository : IBebidaRepository
    {

        private BarContext _context;

        public BebidaRepository(BarContext context)
        {
            _context = context;
        }

        public IList<Bebida> BuscarPor(Expression<Func<Bebida, bool>> filtro)
        {
            return _context.Bebidas.Where(filtro).ToList();
        }

        public void Cadastrar(Bebida bebida)
        {
            _context.Bebidas.Add(bebida);
        }

        public IList<Bebida> Listar()
        {
            return _context.Bebidas.ToList();
        }

        public void Remover(int codigo)
        {
            var bebida = _context.Bebidas.Find(codigo);
            _context.Bebidas.Remove(bebida);
        }
    }
}
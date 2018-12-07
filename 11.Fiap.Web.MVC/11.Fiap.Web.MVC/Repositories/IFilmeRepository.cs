using _11.Fiap.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _11.Fiap.Web.MVC.Units
{
    public interface IFilmeRepository
    {
        void Cadastrar(Filme filme);
        void Atualizar(Filme filme);
        void Remover(int filmeId);
        Filme Buscar(int filmeId);
        IList<Filme> Listar();
        IList<Filme> BuscarPor(Expression<Func<Filme, bool>> filtro);
    }
}

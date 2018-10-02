using _08.Fiap.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _08.Fiap.Web.MVC.Repositories
{
    public interface IDependenteRepository
    {
        void Alterar(Dependente dependente);
        void Cadastrar(Dependente dependente);
        void Remover(int codigo);
        IList<Dependente> listar();
        Dependente Buscar(int codigo);
        IList<Dependente> BuscarPor(Expression<Func<Dependente, bool>> filtro);
    }
}

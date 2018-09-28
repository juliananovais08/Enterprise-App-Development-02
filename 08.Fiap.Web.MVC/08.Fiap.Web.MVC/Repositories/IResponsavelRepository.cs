using _08.Fiap.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _08.Fiap.Web.MVC.Repositories
{

    //TEM QUE COLOCAR O MODIFICADOR DE ACESSO PUBLICO
    public interface IResponsavelRepository
    {
        void Alterar(Responsavel responsavel);
        void Cadastrar(Responsavel responsavel);
        void Remover(int codigo);
        Responsavel Buscar(int codigo);
        IList<Responsavel> Listar();
        IList<Responsavel> BuscarPor(Expression<Func<Responsavel,bool>>filtro);
    }
}

using _09.Fiap.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _09.Fiap.Web.MVC.Repositories
{
    //COLOCAR MODIFICADOR DE ACESSO PUBLICO
    public interface IJogoRepository
    {
        void Cadastrar(Jogo jogo);
        IList<Jogo> Listar();
        void Atualizar(Jogo jogo);
        void Remover(int codigo);
        IList<Jogo> BuscarPor(Expression<Func<Jogo, bool>> filtro);
        Jogo Buscar(int codigo);

    }
}

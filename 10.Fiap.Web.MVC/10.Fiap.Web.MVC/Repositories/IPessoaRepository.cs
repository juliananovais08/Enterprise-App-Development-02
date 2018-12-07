using _10.Fiap.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _10.Fiap.Web.MVC.Repositories
{
    public interface IPessoaRepository
    {
        //CAPITULO 08
        void Cadastrar(Pessoa pessoa);
        void Atualizar(Pessoa pessoa);
        IList<Pessoa> Listar();
        void Remover(int  pessoaId);
        Pessoa Buscar(int pessoaId);
        IList<Pessoa> BuscarPor(Expression<Func<Pessoa, bool>>filtro);  
        
    }
}

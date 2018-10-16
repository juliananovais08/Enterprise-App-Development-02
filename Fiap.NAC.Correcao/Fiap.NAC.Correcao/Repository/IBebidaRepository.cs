using Fiap.NAC.Correcao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.NAC.Correcao.Repository
{
    public interface IBebidaRepository
    {

        void Cadastrar(Bebida bebida);
        void Remover(int codigo);
        IList<Bebida> Listar();
        IList<Bebida> BuscarPor(Expression<Func<Bebida, bool>> filtro);
    }
}

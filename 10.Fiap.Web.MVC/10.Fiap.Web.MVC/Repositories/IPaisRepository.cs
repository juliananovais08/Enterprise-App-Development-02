using _10.Fiap.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Fiap.Web.MVC.Repositories
{
    public interface IPaisRepository
    {
        //CAPITULO 08
        void Cadastrar(Pais Pais);
        IList<Pais> Listar();
    }
}

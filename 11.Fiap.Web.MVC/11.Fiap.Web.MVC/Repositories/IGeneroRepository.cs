using _11.Fiap.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Fiap.Web.MVC.Units
{
    public interface IGeneroRepository
    {
        void Cadastrar(Genero genero);
        IList<Genero> Listar();
    }
}

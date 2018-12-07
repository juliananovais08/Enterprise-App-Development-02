using _09.Fiap.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Fiap.Web.MVC.Repositories
{
    //COLOCAR MODIFICADOR DE ACESSO PUBLICO
    public interface IGeneroRepository
    {

        void Cadastrar(Genero Genero);
        IList<Genero> Listar();
    }
}

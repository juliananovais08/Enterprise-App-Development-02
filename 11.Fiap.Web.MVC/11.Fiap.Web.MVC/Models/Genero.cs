using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _11.Fiap.Web.MVC.Models
{
    public class Genero
    {
        public int GeneroId { get; set; }
        public string Nome { get; set; }

        public IList <Filme> Filmes{ get; set; }
    }
}
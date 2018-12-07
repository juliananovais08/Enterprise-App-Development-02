using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _11.Fiap.Web.MVC.Models
{
    public class Filme
    {
        public int FilmeId { get; set; }
        public string Nome { get; set; }
        public DateTime DataLancamento { get; set; }
        public Tipo? Tipo { get; set; }
        public bool Disponivel { get; set; }

        public Genero Genero { get; set; }
        public int GeneroId { get; set; }
    }
}
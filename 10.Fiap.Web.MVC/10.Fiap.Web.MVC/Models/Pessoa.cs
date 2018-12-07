using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _10.Fiap.Web.MVC.Models
{
    public class Pessoa
    {
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Sexo? Sexo { get; set; }
        public bool Valido { get; set; }

        //CAPITULO 07
        public Pais Pais { get; set; }
        public int PaisId { get; set; }

    }
}
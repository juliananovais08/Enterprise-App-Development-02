using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _09.Fiap.Web.MVC.Models
{
    public class Jogo
    {

        public int JogoId { get; set; }
        public string Nome { get; set; }
        public DateTime DataLancamento  { get; set; }
        public Plataforma Plataforma { get; set; }
        public bool Disponivel { get; set; }

        //Relacionamento
        public Genero Genero { get; set; }
        public int GeneroId { get; set; }
    }


}
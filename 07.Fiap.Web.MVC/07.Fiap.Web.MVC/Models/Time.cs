using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _07.Fiap.Web.MVC.Models
{
    public class Time
    {

        public int TimeId { get; set; }
        public string Nome { get; set; }
        public bool Mundial { get; set; }

        public Tecnico Tecnico { get; set; }
        public int TecnicoId { get; set; }

        public IList<Jogador> Jogadores { get; set; }

        public virtual IList<Campeonato> Campeonatos { get; set; }


    }
}
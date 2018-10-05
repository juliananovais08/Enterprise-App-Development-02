using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _08.Fiap.Web.MVC.Models
{
    public class Dependente
    {
        public int DependenteId { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Bolsista { get; set; }

        //Relacionamento

        public Responsavel Responsavel { get; set; }
        public int ResponsavelId { get; set; }

        public IList<Dependente> Dependentes { get; set; }
    }
}
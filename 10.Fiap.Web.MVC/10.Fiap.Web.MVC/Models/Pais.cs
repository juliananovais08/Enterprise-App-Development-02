using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _10.Fiap.Web.MVC.Models
{
    public class Pais
    {
        public int PaisId { get; set; }
        public string Nome { get; set; }

        //CAPITULO 07
        public IList<Pessoa> Pessoas { get; set; }
    }
}
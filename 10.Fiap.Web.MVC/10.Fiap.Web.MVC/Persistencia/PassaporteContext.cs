using _10.Fiap.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _10.Fiap.Web.MVC.Persistencia
{
    public class PassaporteContext : DbContext  //CAPITULO 06
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Pais> Paises { get; set; }
    }
}
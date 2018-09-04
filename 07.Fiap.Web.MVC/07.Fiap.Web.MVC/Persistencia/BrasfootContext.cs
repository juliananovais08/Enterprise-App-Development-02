using _07.Fiap.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _07.Fiap.Web.MVC.Persistencia
{
    public class BrasfootContext: DbContext
    {
        public DbSet<Time> Times { get; set; }
        public DbSet<Jogador> Jogadores { get; set; }
        public DbSet<Campeonato> Tecnicos { get; set; }
    }
}
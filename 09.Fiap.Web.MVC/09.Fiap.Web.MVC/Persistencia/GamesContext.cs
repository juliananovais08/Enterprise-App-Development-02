using _09.Fiap.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _09.Fiap.Web.MVC.Persistencia
{
    public class GamesContext : DbContext
    {
        public DbSet <Genero> Generos { get; set; }
        public DbSet <Jogo> Jogos { get; set; }
    }
}
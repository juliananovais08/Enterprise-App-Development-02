using _11.Fiap.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _11.Fiap.Web.MVC.Persistencia
{
    public class LocadoraContext : DbContext
    {
        public DbSet<Filme> Filmes { get; set; }
        public DbSet <Genero> Generos { get; set; }
    }
}
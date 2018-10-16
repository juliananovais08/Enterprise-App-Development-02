using Fiap.NAC.Correcao.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap.NAC.Correcao.Persistencia
{
    public class BarContext : DbContext
    {
        public DbSet<Bebida> Bebidas { get; set; }
    }
}
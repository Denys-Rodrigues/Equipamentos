using Equipamentos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Equipamentos.Context
{
    public class EFContext : DbContext
    {
        public EFContext(): base("Projeto") { }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Fabricante> Fabricantes { get; set; }
    }
}
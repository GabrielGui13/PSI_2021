using System;
using Microsoft.EntityFrameworkCore;
using Projeto01.Models;

namespace Projeto01.Models
{
    public class EFContext : DbContext {
        public EFContext(DbContextOptions<EFContext> options) : base(options) { } 
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Fabricante> Fabricantes { get; set; }
    }
}
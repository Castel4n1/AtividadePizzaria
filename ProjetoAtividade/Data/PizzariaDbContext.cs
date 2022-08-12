using Microsoft.EntityFrameworkCore;
using ProjetoAtividade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAtividade.Data
{
    public class PizzariaDbContext : DbContext
    {
        public PizzariaDbContext(DbContextOptions<PizzariaDbContext> options)
            : base(options)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PizzaSabor>().HasKey(ps => new
            {
                ps.PizzaId,
                ps.SaborId
            });
        }

        public DbSet<PizzaSabor> PizzaSabores { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Sabor> Sabores { get; set; }
        public DbSet<Tamanho> Tamanhos { get; set; }


    }
}

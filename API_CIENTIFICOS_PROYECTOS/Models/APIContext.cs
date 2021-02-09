using API_CIENTIFICOS_PROYECTOS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_CIENTIFICOS_PROYECTOS.Models {
    public class APIContext : DbContext {
        public APIContext(DbContextOptions<APIContext> options) : base(options) { }
        public DbSet<Cientifico> Cientificos { get; set; }
        public DbSet<Proyecto> Proyectos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Cientifico>().HasKey(p => p.DNI);

            modelBuilder.Entity<Proyecto>().HasKey(p => p.Id);

            modelBuilder.Entity<Asignado_a>().HasKey(e => new { e.Cientifico_dni, e.Proyecto_id });

            modelBuilder.Entity<Asignado_a>().HasOne<Cientifico>(e => e.Cientifico).WithMany(p => p.Asignaciones);

            modelBuilder.Entity<Asignado_a>().HasOne<Proyecto>(e => e.Proyecto).WithMany(p => p.Asignaciones);
        }
    }
}


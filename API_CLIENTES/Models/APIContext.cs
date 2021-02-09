using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API_CLIENTES.Models;

namespace API_CLIENTES.Models {
    public class APIContext : DbContext {
        public APIContext(DbContextOptions<APIContext> options) : base(options) {}
        public DbSet<Cliente> Clientes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Cliente>().HasMany(p => p.Videos).WithOne(b => b.Cliente);
        }
        public DbSet<API_CLIENTES.Models.Video> Video { get; set; }
    }
}

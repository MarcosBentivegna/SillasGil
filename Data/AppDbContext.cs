using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SillasGil.Models;
using System.Linq;

namespace SillasGil.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ItemInventario> Inventario { get; set; }
    }
}

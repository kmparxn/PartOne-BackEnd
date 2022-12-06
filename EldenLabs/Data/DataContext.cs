using EldenLabs.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace EldenLabs.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Ruta> Rutas { get; set; }
    }
}

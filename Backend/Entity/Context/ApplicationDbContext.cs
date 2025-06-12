using Entity.Configurations;
using Entity.Configurations.Entity.Configurations;
using Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace Entity.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Usuario> Users { get; set; }
        public DbSet<Cliente> Clients { get; set; }
        public DbSet<Vehiculo> Vehicles { get; set; }
        public DbSet<Reserva> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UsuarioConfig());
            modelBuilder.ApplyConfiguration(new ClienteConfig());
            modelBuilder.ApplyConfiguration(new VehiculoConfig());
            modelBuilder.ApplyConfiguration(new ReservaConfig());
        }
    }
}
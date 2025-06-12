using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity.Configurations
{
    public class ReservaConfig : IEntityTypeConfiguration<Reserva>
    {
        public void Configure(EntityTypeBuilder<Reserva> builder)
        {
            builder.ToTable("Reserva");

            builder.HasKey(r => r.Id);

            builder.Property(r => r.FechaInicio)
                .IsRequired();

            builder.Property(r => r.FechaFin)
                .IsRequired();

            builder.Property(r => r.Estado)
                .HasMaxLength(50)
                .HasDefaultValue("Pendiente")
                .IsRequired();

            builder.Property(r => r.Activo)
                .HasColumnType("bit")
                .HasDefaultValue(true);

            builder.HasOne(r => r.Cliente)
                .WithMany(c => c.Reservas)
                .HasForeignKey(r => r.ClienteId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(r => r.Vehiculo)
                .WithMany(v => v.Reservas)
                .HasForeignKey(r => r.VehiculoId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
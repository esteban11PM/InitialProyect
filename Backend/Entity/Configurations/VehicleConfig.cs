using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity.Configurations
{
    public class VehiculoConfig : IEntityTypeConfiguration<Vehiculo>
    {
        public void Configure(EntityTypeBuilder<Vehiculo> builder)
        {
            builder.ToTable("Vehiculo");

            builder.HasKey(v => v.Id);

            builder.Property(v => v.Marca)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(v => v.Modelo)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(v => v.Placa)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(v => v.Anio)
                .IsRequired();

            builder.Property(v => v.Disponible)
                .HasDefaultValue(true)
                .IsRequired();

            builder.Property(v => v.Activo)
                .HasColumnType("bit")
                .HasDefaultValue(true);
        }
    }
}
using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity.Configurations
{
    public class ClienteConfig : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nombre)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.Email)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.Telefono)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(c => c.Activo)
                .HasColumnType("bit")
                .HasDefaultValue(true);

            builder.HasMany(c => c.Reservas)
                .WithOne(r => r.Cliente)
                .HasForeignKey(r => r.ClienteId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

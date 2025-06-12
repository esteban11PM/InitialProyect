using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity.Configurations
{
    namespace Entity.Configurations
    {
        public class UsuarioConfig : IEntityTypeConfiguration<Usuario>
        {
            public void Configure(EntityTypeBuilder<Usuario> builder)
            {
                builder.ToTable("Usuario");

                builder.HasKey(u => u.Id);

                builder.Property(u => u.Username)
                    .HasMaxLength(50)
                    .IsRequired();

                builder.Property(u => u.PasswordHash)
                    .IsRequired();

                builder.Property(u => u.Activo)
                    .HasColumnType("bit")
                    .HasDefaultValue(true);

                builder.HasOne(u => u.Cliente)
                    .WithOne()
                    .HasForeignKey<Usuario>(u => u.ClienteId)
                    .OnDelete(DeleteBehavior.Cascade);
            }
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SADVOApp.Core.Domain.Entities;

namespace SADVOApp.Infraestructure.Persistence.EntityConfigurations
{
    public class UsuarioEntityConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            #region Basic Configuration
            builder.HasKey(u => u.Id);
            builder.ToTable("Usuarios");
            #endregion

            #region Properties Configuration
            builder.Property(u => u.Nombre).IsRequired().HasMaxLength(200);
            builder.Property(u => u.Apellido).IsRequired().HasMaxLength(200);
            builder.Property(u => u.Email).IsRequired().HasMaxLength(250);
            builder.Property(u => u.NombreUsuario).IsRequired().HasMaxLength(100);
            builder.Property(u => u.PasswordHash).IsRequired().HasMaxLength(200);
            builder.Property(u => u.Rol).IsRequired();
            builder.Property(u => u.Estado).IsRequired();
            #endregion

            #region Relationships Configuration
            builder.HasOne(u => u.UsuarioPartido)
                .WithOne(up => up.Usuario)
                .HasForeignKey<UsuarioPartido>(up => up.UsuarioId)
                .OnDelete(DeleteBehavior.Cascade); // Elimina el UsuarioPartido si se elimina el Usuario
            #endregion
        }
    }
}

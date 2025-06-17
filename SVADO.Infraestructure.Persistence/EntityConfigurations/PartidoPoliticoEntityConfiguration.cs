using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SADVOApp.Core.Domain.Entities;

namespace SADVOApp.Infraestructure.Persistence.EntityConfigurations
{
    public class PartidoPoliticoEntityConfiguration : IEntityTypeConfiguration<PartidoPolitico>
    {
        public void Configure(EntityTypeBuilder<PartidoPolitico> builder)
        {
            #region Basic configuration
            builder.HasKey(p => p.Id);
            builder.ToTable("PartidosPoliticos");
            #endregion

            #region Property configurations
            builder.Property(p => p.Nombre).IsRequired().HasMaxLength(200);
            builder.Property(p => p.Siglas).IsRequired().HasMaxLength(20);
            builder.Property(p => p.Descripcion).HasMaxLength(500);
            builder.Property(p => p.LogoPath).IsRequired().HasMaxLength(250);
            builder.Property(p => p.Estado).IsRequired();
            #endregion

            #region Relationships
            builder.HasIndex(p => p.Siglas).IsUnique();
            builder.HasMany(p => p.Candidatos)
                  .WithOne(c => c.Partido)
                  .HasForeignKey(c => c.PartidoId)
                  .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(p => p.Usuarios)
                  .WithOne(up => up.Partido)
                  .HasForeignKey(up => up.PartidoId)
                  .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SADVOApp.Core.Domain.Entities;

namespace SADVOApp.Infraestructure.Persistence.EntityConfigurations
{
    public class EleccionEntityConfiguration : IEntityTypeConfiguration<Eleccion>
    {
        public void Configure(EntityTypeBuilder<Eleccion> builder)
        {
            #region Basic configuration
            builder.HasKey(e => e.Id);
            builder.ToTable("Elecciones");
            #endregion

            #region Property configurations
            builder.Property(e => e.Nombre).IsRequired().HasMaxLength(200);
            builder.Property(e => e.Fecha).IsRequired();
            builder.Property(e => e.Estado).IsRequired();
            #endregion

            #region Relationships
            builder.HasMany(e => e.Votos)
                  .WithOne(v => v.Eleccion)
                  .HasForeignKey(v => v.EleccionId)
                  .OnDelete(DeleteBehavior.Cascade);
            builder.HasIndex(e => new { e.Nombre, e.Fecha }).IsUnique();
            #endregion
        }
    }
}

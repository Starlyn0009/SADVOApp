using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SADVOApp.Core.Domain.Entities;

namespace SADVOApp.Infraestructure.Persistence.EntityConfigurations
{
    public class PuestoElectivoEntityConfiguration : IEntityTypeConfiguration<PuestoElectivo>
    {
        public void Configure(EntityTypeBuilder<PuestoElectivo> builder)
        {
            #region Basic configuration
            builder.HasKey(pe => pe.Id);
            builder.ToTable("PuestosElectivos");
            #endregion

            #region Property configurations
            builder.Property(pe => pe.Nombre).IsRequired().HasMaxLength(200);
            builder.Property(pe => pe.Descripcion).IsRequired().HasMaxLength(500);
            builder.Property(pe => pe.Estado).IsRequired();
            #endregion

            #region Relationships
            builder.HasMany(pe => pe.Candidatos)
                  .WithOne(cp => cp.PuestoElectivo)
                  .HasForeignKey(cp => cp.PuestoElectivoId)
                  .OnDelete(DeleteBehavior.Restrict);
            #endregion
        }
    }
}

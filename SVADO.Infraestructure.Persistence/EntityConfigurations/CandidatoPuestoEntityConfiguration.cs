using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SADVOApp.Core.Domain.Entities;

namespace SADVOApp.Infraestructure.Persistence.EntityConfigurations
{
    public class CandidatoPuestoEntityConfiguration : IEntityTypeConfiguration<CandidatoPuesto>
    {
        public void Configure(EntityTypeBuilder<CandidatoPuesto> builder)
        {
            #region Basic configuration
            builder.HasKey(cp => cp.Id);
            builder.ToTable("CandidatosPuestos");
            #endregion

            #region Property configurations
            builder.Property(cp => cp.Id).ValueGeneratedOnAdd();
            #endregion

            #region Relationships
            builder.HasIndex(cp => new { cp.CandidatoId, cp.PuestoElectivoId, cp.PartidoId }).IsUnique();
            // Relaciones configuradas en Candidato y PuestoElectivo
            #endregion
        }
    }
}

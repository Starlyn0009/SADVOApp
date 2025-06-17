using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SADVOApp.Core.Domain.Entities;

namespace SADVOApp.Infraestructure.Persistence.EntityConfigurations
{
    public class CandidatoEntityConfiguration : IEntityTypeConfiguration<Candidato>
    {
        public void Configure(EntityTypeBuilder<Candidato> builder)
        {
            #region Basic configuration
            builder.HasKey(c => c.Id);
            builder.ToTable("Candidatos");
            #endregion

            #region Property configurations
            builder.Property(c => c.Nombre).IsRequired().HasMaxLength(200);
            builder.Property(c => c.Apellido).IsRequired().HasMaxLength(200);
            builder.Property(c => c.FotoPath).IsRequired().HasMaxLength(250);
            builder.Property(c => c.Estado).IsRequired();
            #endregion

            #region Relationships
            builder.HasOne(c => c.Partido)
                  .WithMany(p => p.Candidatos)
                  .HasForeignKey(c => c.PartidoId)
                  .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(c => c.CandidatosPorPuesto)
                  .WithOne(cp => cp.Candidato)
                  .HasForeignKey(cp => cp.CandidatoId)
                  .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}

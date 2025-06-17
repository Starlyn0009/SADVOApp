using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SADVOApp.Core.Domain.Entities;

namespace SADVOApp.Infraestructure.Persistence.EntityConfigurations
{
    public class VotoEntityConfiguration : IEntityTypeConfiguration<Voto>
    {
        public void Configure(EntityTypeBuilder<Voto> builder)
        {
            #region Basic configuration
            builder.HasKey(v => v.Id);
            builder.ToTable("Votos");
            #endregion

            #region Property configurations
            builder.Property(v => v.FechaVoto).IsRequired();
            #endregion

            #region Relationships
            builder.HasOne(v => v.Ciudadano)
                  .WithMany(c => c.Votos)
                  .HasForeignKey(v => v.CiudadanoId)
                  .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(v => v.Candidato)
                  .WithMany()
                  .HasForeignKey(v => v.CandidatoId)
                  .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(v => v.PuestoElectivo)
                  .WithMany()
                  .HasForeignKey(v => v.PuestoElectivoId)
                  .OnDelete(DeleteBehavior.Restrict);
            #endregion
        }
    }
}

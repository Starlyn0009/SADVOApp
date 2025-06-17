using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SADVOApp.Core.Domain.Entities;

namespace SADVOApp.Infraestructure.Persistence.EntityConfigurations
{
    public class AlianzaPoliticaEntityConfiguration : IEntityTypeConfiguration<AlianzaPolitica>
    {
        public void Configure(EntityTypeBuilder<AlianzaPolitica> builder)
        {
            #region Basic configuration
            builder.HasKey(a => a.Id);
            builder.ToTable("AlianzasPoliticas");
            #endregion

            #region Property configurations
            builder.Property(a => a.FechaSolicitud).IsRequired();
            builder.Property(a => a.EstadoAlianza).IsRequired();
            #endregion

            #region Relationships
            builder.HasOne(a => a.PartidoOrigen)
                  .WithMany()
                  .HasForeignKey(a => a.PartidoOrigenId)
                  .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(a => a.PartidoDestino)
                  .WithMany()
                  .HasForeignKey(a => a.PartidoDestinoId)
                  .OnDelete(DeleteBehavior.Restrict);
            #endregion
        }
    }
}

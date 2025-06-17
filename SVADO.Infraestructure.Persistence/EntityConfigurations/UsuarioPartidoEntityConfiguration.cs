using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SADVOApp.Core.Domain.Entities;

namespace SADVOApp.Infraestructure.Persistence.EntityConfigurations
{
    public class UsuarioPartidoEntityConfiguration : IEntityTypeConfiguration<UsuarioPartido>
    {
        public void Configure(EntityTypeBuilder<UsuarioPartido> builder)
        {
            #region Basic configuration
            builder.HasKey(up => up.UsuarioId);
            builder.ToTable("UsuariosPartidos");
            #endregion

            #region Relationships
            // Configurado en Usuario y PartidoPolitico
            #endregion
        }
    }
}

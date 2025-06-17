using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SADVOApp.Core.Domain.Entities;

namespace SADVOApp.Infraestructure.Persistence.EntityConfigurations
{
    public class CiudadanoEntityConfiguration : IEntityTypeConfiguration<Ciudadano>
    {
        public void Configure(EntityTypeBuilder<Ciudadano> builder)
        {
            #region Basic configuration
            builder.HasKey(c => c.Id);
            builder.ToTable("Ciudadanos");
            #endregion

            #region Property configurations
            builder.Property(c => c.Nombre).IsRequired().HasMaxLength(200);
            builder.Property(c => c.Apellido).IsRequired().HasMaxLength(200);
            builder.Property(c => c.Email).IsRequired().HasMaxLength(250);
            builder.Property(c => c.Cedula).IsRequired().HasMaxLength(50);
            builder.Property(c => c.Havotado).IsRequired();
            #endregion

            #region Relationships
            builder.HasIndex(c => c.Cedula).IsUnique();
            builder.HasMany(c => c.Votos)
                  .WithOne(v => v.Ciudadano)
                  .HasForeignKey(v => v.CiudadanoId)
                  .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}

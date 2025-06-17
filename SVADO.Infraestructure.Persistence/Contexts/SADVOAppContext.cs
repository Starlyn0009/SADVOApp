using System.Reflection;
using Microsoft.EntityFrameworkCore;
using SADVOApp.Core.Domain.Entities;

namespace SADVO.Infraestructure.Persistence.Contexts
{
    public class SADVOAppContext :DbContext
    {
        public SADVOAppContext(DbContextOptions<SADVOAppContext> options) : base(options) { }
        
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<UsuarioPartido> UsuariosPartidos { get; set; }
        public DbSet<PuestoElectivo> PuestosElectivos { get; set; }
        public DbSet<PartidoPolitico> PartidosPoliticos { get; set; }
        public DbSet<Eleccion> Elecciones { get; set; }
        public DbSet<Ciudadano> Ciudadanos { get; set; }
        public DbSet<CandidatoPuesto> CandidatosPuestos { get; set; }
        public DbSet<Candidato> Candidatos { get; set; }
        public DbSet<AlianzaPolitica> AlianzasPoliticas { get; set; }
        public DbSet<Voto> Votos { get; set; }

        // Este metodo esta llamado por el runtime para configurar el modelo y las relaciones
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // Llama al metodo base para aplicar configuraciones por defecto

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}

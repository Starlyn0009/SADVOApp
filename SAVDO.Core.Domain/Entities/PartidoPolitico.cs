using SADVOApp.Core.Domain.Common;

namespace SADVOApp.Core.Domain.Entities
{
    public class PartidoPolitico : BaseEntiy<int>
    {
        public required string Nombre { get; set; }
        public required string Siglas { get; set; }
        public  string? Descripcion { get; set; }
        public required string LogoPath { get; set; }

        // Navigation propertiess
        public ICollection<Candidato> Candidatos { get; set; } = new List<Candidato>();
        public ICollection<UsuarioPartido> Usuarios { get; set; } = new List<UsuarioPartido>();

    }
}

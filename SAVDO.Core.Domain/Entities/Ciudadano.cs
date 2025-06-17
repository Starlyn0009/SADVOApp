using SADVOApp.Core.Domain.Common;

namespace SADVOApp.Core.Domain.Entities
{
   public class Ciudadano : PersonaBase
   {
        public required string Email { get; set; }
        public required string Cedula { get; set; }
        public required bool Havotado { get; set; }
        // Navigation properties
        public ICollection<Voto> Votos { get; set; } = new List<Voto>();
    }
}

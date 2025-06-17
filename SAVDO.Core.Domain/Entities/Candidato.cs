using SADVOApp.Core.Domain.Common;

namespace SADVOApp.Core.Domain.Entities
{
    public class Candidato : PersonaBase
    {
        public required string FotoPath { get; set; }
        public int PartidoId { get; set; }

        // Navigation properties
        public required PartidoPolitico Partido { get; set; }
        public ICollection<CandidatoPuesto> CandidatosPorPuesto { get; set; } = new List<CandidatoPuesto>();
    }
}

using SADVOApp.Core.Domain.Common.Enums;

namespace SADVOApp.Core.Domain.Entities
{
    public class AlianzaPolitica
    {
        public int Id { get; set; }
        
        public int PartidoOrigenId { get; set; }
        public required PartidoPolitico PartidoOrigen { get; set; }

        public int PartidoDestinoId { get; set; }
        public required PartidoPolitico PartidoDestino { get; set; }

        public DateTime FechaSolicitud { get; set; }

        public EstadoAlianza EstadoAlianza { get; set; }
    }
}

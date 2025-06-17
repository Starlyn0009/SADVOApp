using SADVOApp.Core.Domain.Common.Enums;

namespace SADVOApp.Core.Application.Dtos.AlianzaPoliticaDto
{
    public class AlianzaPoliticaDto : BaseEntityDto<int>
    {
        public int PartidoOrigenId { get; set; }
        public int PartidoDestinoId { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public EstadoAlianza EstadoAlianza { get; set; }
    }
}

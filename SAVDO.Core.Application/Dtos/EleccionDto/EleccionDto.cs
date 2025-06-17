using SADVOApp.Core.Domain.Common.Enums;

namespace SADVOApp.Core.Application.Dtos.EleccionDto
{
    public class EleccionDto : BaseEntityDto<int>
    {
        public required string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public  EstadoEleccion EstadoEleccion { get; set; } 
    }
}

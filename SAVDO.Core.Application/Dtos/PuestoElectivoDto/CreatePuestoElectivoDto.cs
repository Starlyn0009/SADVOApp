using System.ComponentModel.DataAnnotations;

namespace SADVOApp.Core.Application.Dtos.PuestoElectivoDto
{
    public class CreatePuestoPoliticoDto : BaseEntityDto<int>
    {
        [Required]
        [MaxLength(200)]
        public required string Nombre { get; set; }

        [Required]
        [MaxLength(500)]
        public required string Descripcion { get; set; }
    }    
}

namespace SADVOApp.Core.Application.Dtos.PuestoElectivoDto
{
    public class PuestoElectivoDto : BaseEntityDto<int>
    {
        public required string Nombre { get; set; }
        public required string Descripcion { get; set; }
              
    }    
}

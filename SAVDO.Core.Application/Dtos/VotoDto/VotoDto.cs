namespace SADVOApp.Core.Application.Dtos.VotoDto
{
    public class VotoDto : BaseEntityDto<int>
    {
        public int CiudadanoId { get; set; }
        public int EleccionId { get; set; }
        public int CandidatoId { get; set; }
        public int PuestoElectivoId { get; set; }
        public DateTime FechaVoto { get; set; }
    }
}

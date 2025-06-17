namespace SADVOApp.Core.Application.Dtos.VotoDto
{
    public class CreateVotoDto 
    {
        public int CiudadanoId { get; set; }
        public int EleccionId { get; set; }
        public int CandidatoId { get; set; }
        public int PuestoElectivoId { get; set; }

    }    
}

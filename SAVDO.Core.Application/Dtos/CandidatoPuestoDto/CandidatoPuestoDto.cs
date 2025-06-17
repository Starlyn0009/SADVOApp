namespace SADVOApp.Core.Application.Dtos.CandidatoPuestoDto
{
    public class CandidatoPuestoDto : BaseEntityDto<int>
    {
        public int CadidatoId { get; set; }
        public int PuestoElectivoId { get; set; }
        public int PartidoId { get; set; }
    }
}

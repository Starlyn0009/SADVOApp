namespace SADVOApp.Core.Application.Dtos.CandidatoDto
{
    public class CandidatoDto : PersonaBaseDto<int>
    {
        public required string FotoPath { get; set; }
        public int PartidoId { get; set; }
    }
}

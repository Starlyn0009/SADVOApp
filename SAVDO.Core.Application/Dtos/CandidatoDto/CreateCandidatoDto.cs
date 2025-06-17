namespace SADVOApp.Core.Application.Dtos.CandidatoDto
{
    public class CreateCandidatoDto
    {
        public required string Nombre { get; set; }
        public required string Apellido { get; set; }
        public required string FotoPath { get; set; }
        public int PartidoId { get; set; }
    }    
}

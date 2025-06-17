namespace SADVOApp.Core.Application.Dtos.PartidoPoliticoDto
{
    public class CreatePartidoPoliticoDto 
    {
        public required string Nombre { get; set; }
        public required string Siglas { get; set; }
        public string? Descripcion { get; set; }
        public required string LogoPath { get; set; }
    }    
}

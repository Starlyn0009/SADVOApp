namespace SADVOApp.Core.Application.Dtos.CiudadanoDto
{
    public class CreateCiudadanoDto
    {
        public required string Nombre { get; set; }
        public required string Apellido { get; set; }
        public required string Email { get; set; }
        public required string Cedula { get; set; } 
    }    
}

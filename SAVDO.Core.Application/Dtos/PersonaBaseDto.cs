namespace SADVOApp.Core.Application.Dtos
{
    public class PersonaBaseDto<Tkey> : BaseEntityDto<Tkey>
    {
        public required string Nombre { get; set; }
        public required string Apellido { get; set; }
    }
}

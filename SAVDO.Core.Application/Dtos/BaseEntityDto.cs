namespace SADVOApp.Core.Application.Dtos
{
    public class BaseEntityDto<Tkey>
    {
        public required Tkey Id { get; set; }
        public required bool Estado { get; set; }
    }    
}

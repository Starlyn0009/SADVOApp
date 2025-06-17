namespace SADVOApp.Core.Domain.Common
{
    public abstract class PersonaBase : BaseEntiy<int>
    {
        public  required string Nombre { get; set; }
        public required string Apellido { get; set; }
    }
}

namespace SADVOApp.Core.Domain.Common
{
    public abstract class BaseEntiy<TKey>
    {
        public required TKey Id { get; set; }
        public required bool Estado { get; set; }
    }
   
}

﻿namespace SADVOApp.Core.Domain.Interfaces
{
   public interface IGenericRepository<Entity>
        where Entity : class // Entity se a adaptara a cualquier clase que se le pase
   {
        Task<Entity?> AddAsync(Entity entity);
        Task<List<Entity>?> AddRangeAsync(List<Entity> entities);
        Task DeleteAsync(int id);
        Task<List<Entity>> GetAllList();
        IQueryable<Entity> GetAllQuery();
        Task<Entity?> GetById(int id);
        Task<Entity?> UpdateAsync(int id, Entity entity);
        Task<List<Entity>> GetAllListWithInclude(List<string> properties);
        IQueryable<Entity> GetAllQueryWithInclude(List<string> properties);
    }
}

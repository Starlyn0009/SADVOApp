using Microsoft.EntityFrameworkCore;
using SADVO.Infraestructure.Persistence.Contexts;
using SADVOApp.Core.Domain.Interfaces;

namespace SADVOApp.Infraestructure.Persistence.Repositories
{
    public class GenericRepository<Entity> : IGenericRepository<Entity> // Este Repositorio Generico se adaptara a cualquier clase que se le pase como parametro
        where Entity : class
    {
        private readonly SADVOAppContext _context;

        public GenericRepository(SADVOAppContext context) // Inyeccion de dependencias del contexto
        {
            _context = context;
        }
        
        // Metodo para agregar 
        public virtual async Task<Entity?> AddAsync(Entity entity)
        {
            await _context.Set<Entity>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        // Metodo para agregar un rango de entidades
        public virtual async Task<List<Entity>?> AddRangeAsync(List<Entity> entites)
        {
            await _context.Set<Entity>().AddRangeAsync(entites);
            await _context.SaveChangesAsync();
            return entites;
        }

        // Metodo para editar 
        public virtual async Task<Entity?> UpdateAsync(int id, Entity entity)
        {
            var entry = _context.Set<Entity>().Find(id);

            if(entry != null)
            {
                _context.Entry(entry).CurrentValues.SetValues(entity);
                await _context.SaveChangesAsync(); 
                return entry;
            }
            return null;
        }

        // Metodo para eliminar
        public virtual async Task DeleteAsync(int id)
        {
            var entry = await _context.Set<Entity>().FindAsync(id);

            if( entry != null)
            {
                 _context.Set<Entity>().Remove(entry);
                 await _context.SaveChangesAsync();
            }          
        }

        // Metodo para obtener todas las entidades
        public virtual async Task<List<Entity>> GetAllList()
        {
            return await _context.Set<Entity>().ToListAsync();
        }

        // Metodo para obter por id 
        public virtual async Task<Entity?> GetById(int id)
        {
            return await _context.Set<Entity>().FindAsync(id);
        }

        // Metodo with include para obtener una consulta con propiedades relacionadas

        public virtual async Task<List<Entity>> GetAllListWithInclude(List<string> propierties)
        {
            var query = _context.Set<Entity>().AsQueryable();

            foreach (var property in propierties)
            {
                query = query.Include(property);
            }
            return await query.ToListAsync(); // Retorna la lista de entidades con las propiedades relacionadas
        }
        // Metodo with include para obtener una consulta con propiedades relacionadas
        public virtual IQueryable<Entity> GetAllQuery()
        {
            return _context.Set<Entity>().AsQueryable();
        }

        // Metodo with include para obtener una consulta con propiedades relacionadas
        public virtual IQueryable<Entity> GetAllQueryWithInclude(List<string> properties)
        {
            var query = _context.Set<Entity>().AsQueryable();

            foreach(var property in properties)
            {
                query = query.Include(property);
            }
            return query;
        }
    }
}

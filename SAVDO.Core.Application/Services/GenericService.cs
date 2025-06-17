using AutoMapper;
using SADVOApp.Core.Application.Interfaces;
using SADVOApp.Core.Domain.Interfaces;

namespace SADVOApp.Core.Application.Services
{
    public class GenericService<Entity,DtoModel> : IGenericService<DtoModel>
        where Entity : class
        where DtoModel : class
    {
        private readonly IGenericRepository<Entity> _repository;
        private readonly IMapper _mapper;

        // Constructor to inject the repository and mapper
        public GenericService(IGenericRepository<Entity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // Metodo para agregar un nuevo elemento
        public async Task<DtoModel?> AddAsync(DtoModel dto)
        {
            try
            {
                Entity entity = _mapper.Map<Entity>(dto);
                Entity? returnEntity = await _repository.AddAsync(entity);               
                if (returnEntity == null)
                {
                    return null;
                }
                return _mapper.Map<DtoModel>(returnEntity);
                
            }
            catch (Exception)
            {
                return null;
            }
        }
        // Metodo para actualizar un elemento por su ID
        public async Task<DtoModel?> UpdateAsync(DtoModel dto,int id)
        {         
            try
            {
                Entity entity = _mapper.Map<Entity>(dto);
                Entity? returnEntity = await _repository.UpdateAsync(id,entity);
                if (returnEntity == null)
                {
                    return null;
                }
                return _mapper.Map<DtoModel>(returnEntity);
            }
            catch (Exception)
            {
                return null;
            }
        }
        // Metodo para eliminar un elemento por su ID
        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                 await _repository.DeleteAsync(id);
                 return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        // Metodo para obtener un elemento por su ID
        public async Task<DtoModel?> GetById(int id)
        {
            try
            {
                var entity = await _repository.GetById(id);
                if (entity == null)
                {
                    return null;
                }
                DtoModel dto = _mapper.Map<DtoModel>(entity);
                return dto;
            }
            catch (Exception)
            {
                return null;
            }
        }
        //Metodo para obtener todos los elementos
        public async Task<List<DtoModel>> GetAll()
        {
            try
            {
                var listEntites = await _repository.GetAllList();
                var listEntitiesDto = _mapper.Map<List<DtoModel>>(listEntites);

                return listEntitiesDto;
            }
            catch (Exception)
            {
                return [];
            }
        }
    }
}

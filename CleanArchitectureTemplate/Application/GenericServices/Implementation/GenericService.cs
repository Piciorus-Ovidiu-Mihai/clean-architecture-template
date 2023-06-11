using Application.GenericServices.Interfaces;
using Domain.RepositoryInterfaces.Repositories;

namespace Application.GenericServices
{
    public class GenericService<T> : IGenericService<T> where T: BaseEntity
    {
        private readonly IBaseRepository<T> baseRepository;

        public GenericService(IBaseRepository<T> _baseRepository)
        {
            this.baseRepository = _baseRepository;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await baseRepository.GetAllAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await baseRepository.GetById(id);
        }

        public void Create(T entity)
        {
            baseRepository.Add(entity);
        }

        public void Update(T entity)
        {
            baseRepository.Edit(entity);
        }

        public void Delete(T entity)
        {
            baseRepository.Delete(entity);
        }

        public void DeleteById(int id)
        {
            baseRepository.DeleteById(id);
        }
    }
}

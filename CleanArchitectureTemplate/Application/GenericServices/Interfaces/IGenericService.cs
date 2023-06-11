namespace Application.GenericServices.Interfaces
{
    public interface IGenericService<T>
    {
        void Create(T entity);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        void Update(T entity);
        void DeleteById(int id);

        void Delete(T entity);
    }
}

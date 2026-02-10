namespace REPO_GENERICMETHOD.DAL.Iinterfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task  Add(T entity);
        Task <T> GetById(int id);
        Task Delete(T entity);
        void Update(T entity);
    }
}

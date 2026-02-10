using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using REPO_GENERICMETHOD.DAL.Iinterfaces;
using REPO_GENERICMETHOD.DAL.IRepositories;

namespace REPO_GENERICMETHOD.DAL.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbcontext _dbcontext;

        public GenericRepository(ApplicationDbcontext dbcontext) 
        
        {
            _dbcontext = dbcontext;
        }

        public async  Task  Add(T entity)
        {
          
            await  _dbcontext.Set<T>().AddAsync(entity);

            
        }

        public async Task Delete(T entity)
        {
            
            
                _dbcontext.Set<T>().Remove(entity);
            
            

        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbcontext.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            var res = await _dbcontext.Set<T>().FindAsync(id);
            
            return res;
        }

        public void Update(T entity)
        {
            _dbcontext.Set<T>().Update(entity);
        }
    }
}

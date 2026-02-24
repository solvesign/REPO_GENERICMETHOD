using REPO_GENERICMETHOD.DAL.Iinterfaces;
using REPO_GENERICMETHOD.DAL.IRepositories;
using REPO_GENERICMETHOD.Models;

namespace REPO_GENERICMETHOD.DAL.Repositories
{
    public class CategoryRepository:GenericRepository<Category>,ICategoryRepository
    {

        public CategoryRepository(ApplicationDbcontext dbcontext): base(dbcontext)
        {
        
        
        }
    }
}

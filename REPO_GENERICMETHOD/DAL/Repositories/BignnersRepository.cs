using REPO_GENERICMETHOD.DAL.Iinterfaces;
using REPO_GENERICMETHOD.DAL.IRepositories;
using REPO_GENERICMETHOD.Models;

namespace REPO_GENERICMETHOD.DAL.Repositories
{
    public class BignnersRepository:GenericRepository<Bignners>,IBignnersRepository
    {

        public BignnersRepository(ApplicationDbcontext dbcontext): base(dbcontext)
        {
        
        
        }
    }
}

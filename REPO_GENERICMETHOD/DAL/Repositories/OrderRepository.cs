using REPO_GENERICMETHOD.DAL.Iinterfaces;
using REPO_GENERICMETHOD.DAL.IRepositories;
using REPO_GENERICMETHOD.Models;

namespace REPO_GENERICMETHOD.DAL.Repositories
{
    public class OrderRepository:GenericRepository<Order>,IOrderRepository
    {

        public OrderRepository(ApplicationDbcontext dbcontext): base(dbcontext)
        {
        
        
        }
    }
}

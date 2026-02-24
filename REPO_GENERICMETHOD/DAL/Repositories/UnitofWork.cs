using REPO_GENERICMETHOD.DAL.Iinterfaces;
using REPO_GENERICMETHOD.DAL.IRepositories;

namespace REPO_GENERICMETHOD.DAL.Repositories
{
    public class UnitofWork : IUnitofWork
    {
        
        public IPlayerRepository _playerRepository { get; }
        public IBignnersRepository _bignnersRepository { get; }

        public IOrderRepository _orderRepository { get; }

        public ICategoryRepository _categoryRepository { get; }

        private readonly ApplicationDbcontext _Dbcontext;
        public UnitofWork(ApplicationDbcontext dbcontext, IPlayerRepository playerRepository,IBignnersRepository bignnersRepository,
            
            IOrderRepository orderRepository, ICategoryRepository categoryRepository)

        
        {
            _Dbcontext = dbcontext;
            _playerRepository = playerRepository;
            _bignnersRepository = bignnersRepository;
            _orderRepository = orderRepository;
            _categoryRepository = categoryRepository;
        }

      

        public void Dispose()
        {
            _Dbcontext.Dispose();
        }

        public int Save()
        {
           return _Dbcontext.SaveChanges();
           
        }
    }
}

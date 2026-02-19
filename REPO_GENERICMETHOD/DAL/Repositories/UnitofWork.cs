using REPO_GENERICMETHOD.DAL.Iinterfaces;
using REPO_GENERICMETHOD.DAL.IRepositories;

namespace REPO_GENERICMETHOD.DAL.Repositories
{
    public class UnitofWork : IUnitofWork
    {
        
        public IPlayerRepository _playerRepository { get; }
        public IBignnersRepository _bignnersRepository { get; }

        public IOrderRepository _orderRepository { get; }

        private readonly ApplicationDbcontext _Dbcontext;
        public UnitofWork(ApplicationDbcontext dbcontext, IPlayerRepository playerRepository,IBignnersRepository bignnersRepository,
            IOrderRepository orderRepository)

        
        {
            _Dbcontext = dbcontext;
            _playerRepository = playerRepository;
            _bignnersRepository = bignnersRepository;
            _orderRepository = orderRepository;
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

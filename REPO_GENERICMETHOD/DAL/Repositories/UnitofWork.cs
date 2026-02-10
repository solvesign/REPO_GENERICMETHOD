using REPO_GENERICMETHOD.DAL.Iinterfaces;
using REPO_GENERICMETHOD.DAL.IRepositories;

namespace REPO_GENERICMETHOD.DAL.Repositories
{
    public class UnitofWork : IUnitofWork
    {
        
        public IPlayerRepository _playerRepository { get; }
        public IBignnersRepository _bignnersRepository { get; }

        private readonly ApplicationDbcontext _Dbcontext;
        public UnitofWork(ApplicationDbcontext dbcontext, IPlayerRepository playerRepository,IBignnersRepository bignnersRepository)
        
        {
            _Dbcontext = dbcontext;
            _playerRepository = playerRepository;
            _bignnersRepository = bignnersRepository;
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

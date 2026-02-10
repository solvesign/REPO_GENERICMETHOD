using Microsoft.EntityFrameworkCore;
using REPO_GENERICMETHOD.DAL.Iinterfaces;
using REPO_GENERICMETHOD.DAL.IRepositories;
using REPO_GENERICMETHOD.Models;

namespace REPO_GENERICMETHOD.DAL.Repositories
{
    public class PlayerRepository :GenericRepository<Player>,IPlayerRepository
    {

        public PlayerRepository(ApplicationDbcontext dbcontext) : base(dbcontext) { }

    }
}

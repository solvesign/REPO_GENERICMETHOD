using Microsoft.EntityFrameworkCore;
using REPO_GENERICMETHOD.Models;

namespace REPO_GENERICMETHOD.DAL.IRepositories
{
    public class ApplicationDbcontext:DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
        {
        
        
        
        }
        public DbSet<Player> PlayersRec { get; set; }

        public DbSet<Bignners> BignnersRec { get; set; }
    }

}



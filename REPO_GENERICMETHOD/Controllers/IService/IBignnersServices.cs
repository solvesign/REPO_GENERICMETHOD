using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Update.Internal;
using REPO_GENERICMETHOD.Models;

namespace REPO_GENERICMETHOD.Controllers.IService
{
    public interface IBignnersServices
    {
        Task <IEnumerable<Bignners>> GetAllBignners();
          bool DeleteBignners(Bignners Bignners);
        Task <bool> AddBignners(Bignners Bignners);

        Task  <Bignners> GetBignnersByID(int Id);

       bool UpdateBignners(Bignners Bignners);

    }
}

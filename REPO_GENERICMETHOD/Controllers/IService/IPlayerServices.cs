using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Update.Internal;
using REPO_GENERICMETHOD.Models;

namespace REPO_GENERICMETHOD.Controllers.IService
{
    public interface IPlayerServices
    {
        Task <IEnumerable<Player>> GetAllPlayers();
       bool DeletePlayers(Player play);
        Task <bool> AddPlayers(Player player);

        Task  <Player> GetPlayerByID(int Id);

      Task <bool> UpdatePlayer(Player player);

    }
}

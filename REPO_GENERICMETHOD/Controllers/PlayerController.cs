using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using REPO_GENERICMETHOD.Controllers.IService;
using REPO_GENERICMETHOD.Models;

namespace REPO_GENERICMETHOD.Controllers
{
    public class PlayerController : Controller
    {
        private readonly IPlayerServices _playerServices;

        public PlayerController(IPlayerServices playerServices)
        {
            _playerServices = playerServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetallPlayers()
        {
            var res = await _playerServices.GetAllPlayers();

            return View(res);
        }
        [HttpGet]
        public async Task<IActionResult> ADD_PLayer()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ADD_PLayer(Player player)
        {
            var res = await _playerServices.AddPlayers(player);

            return RedirectToAction("GetallPlayers");
        }
        [HttpGet]

        public async Task <IActionResult>  Edit_Player(int id)
        {
            var res = await _playerServices.GetPlayerByID(id);
            
            return View(res);
        }
       
        [HttpPost]

        public async Task<IActionResult> Edit_Player(Player player)
        {
            var res1 = _playerServices.UpdatePlayer(player);

            return RedirectToAction("GetallPlayers");
        }
        [HttpGet]

        public async Task<IActionResult> DetailsofPlayer(int id)
        {
            var res1 = await _playerServices.GetPlayerByID(id);

            return View(res1);

        }
        [HttpGet]
        public async Task < IActionResult>  DeletePlayer(int id)
        {
            var res = await _playerServices.GetPlayerByID(id);

            _playerServices.DeletePlayers(res);
            
            return RedirectToAction("GetallPlayers");

        }




    }



}

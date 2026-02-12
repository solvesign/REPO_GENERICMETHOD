using Microsoft.AspNetCore.Mvc;
using REPO_GENERICMETHOD.Controllers.IService;
using REPO_GENERICMETHOD.Models;

namespace REPO_GENERICMETHOD.Controllers
{
    public class BignnerController : Controller
    {
        private readonly IBignnersServices _bignnersServices;

        public BignnerController(IBignnersServices bignnersServices)
        {
            _bignnersServices = bignnersServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetallBignners()
        {
            var res = await _bignnersServices.GetAllBignners();

            return View(res);
        }
        [HttpGet]
        public async Task<IActionResult> ADD_Bignners()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ADD_Bignners(Bignners Bignners)
        {
            var res = await _bignnersServices.AddBignners(Bignners);

            return RedirectToAction("GetallBignners");
        }
        [HttpGet]

        public async Task <IActionResult>  Edit_Bignners(int id)
        {
            var res = await _bignnersServices.GetBignnersByID(id);
            
            return View(res);
        }
       
        [HttpPost]

        public async Task<IActionResult> Edit_Bignners(Bignners Bignners)
        {
            var res1 = _bignnersServices.UpdateBignners(Bignners);

            return RedirectToAction("GetallBignners");
        }
        [HttpGet]

        public async Task<IActionResult> DetailsofBignners(int id)
        {
            var res1 = await _bignnersServices.GetBignnersByID(id);

            return View(res1);

        }
        [HttpGet]
        public async Task < IActionResult>  DeleteBignners(int id)
        {
            var res = await _bignnersServices.GetBignnersByID(id);

            _bignnersServices.DeleteBignners(res);
            
            return RedirectToAction("GetallBignners");

        }




    }



}

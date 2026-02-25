using Microsoft.AspNetCore.Mvc;
using REPO_GENERICMETHOD.Controllers.IService;
using REPO_GENERICMETHOD.DAL.IRepositories;
using REPO_GENERICMETHOD.Models;

namespace REPO_GENERICMETHOD.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryServices _categoryServices;
        private readonly ApplicationDbcontext _applicationDbcontext;

        

        public CategoryController(ICategoryServices categoryServices, ApplicationDbcontext applicationDbcontext)
        {
            _categoryServices = categoryServices;
            _applicationDbcontext = applicationDbcontext;
        }

        [HttpGet]
        public async Task<IActionResult> GetallCategory()
        {
            var res = await _categoryServices.GetAllcategory();

            return View(res);
        }
        [HttpGet]
        public async Task<IActionResult> ADD_Category()
        {
            

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ADD_Category(Category category)
        {
           
            var res = await _categoryServices.Addcategory(category);

            return RedirectToAction("GetallCategory");
        }
        [HttpGet]

        public async Task <IActionResult>  Edit_Category(int id)
        {
            var res = await _categoryServices.GetcategoryByID(id);
            
            return View(res);
        }
       
        [HttpPost]

        public async Task<IActionResult> Edit_Category(Category category) 
        { 

     
            var res1 = _categoryServices.Updatecategory(category);

            return RedirectToAction("GetallCategory");
        }
        [HttpGet]

        public async Task<IActionResult> DetailsofCategory(int id)
        {
            var res1 = await _categoryServices.GetcategoryByID(id);

            return View(res1);

        }
        [HttpGet]
        public async Task < IActionResult>  DeleteCAtegory(int id)
        {
            var res = await _categoryServices.GetcategoryByID(id);

            _categoryServices.Deletecategorys(res);
            
            return RedirectToAction("GetallCategory");

        }




    }



}

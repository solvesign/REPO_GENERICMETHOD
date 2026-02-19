using Microsoft.AspNetCore.Mvc;
using REPO_GENERICMETHOD.Controllers.IService;
using REPO_GENERICMETHOD.DAL.IRepositories;
using REPO_GENERICMETHOD.Models;

namespace REPO_GENERICMETHOD.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderServices _OrderServices;
        private readonly ApplicationDbcontext _applicationDbcontext;

        

        public OrderController(IOrderServices OrderServices, ApplicationDbcontext applicationDbcontext)
        {
            _OrderServices = OrderServices;
            _applicationDbcontext = applicationDbcontext;
        }

        [HttpGet]
        public async Task<IActionResult> GetallOrder()
        {
            var res = await _OrderServices.GetAllOrders();

            return View(res);
        }
        [HttpGet]
        public async Task<IActionResult> ADD_Order()
        {
            var productdetails = _applicationDbcontext.Product.Select(x => new Product
            {
               Name = x.Name,
              
             ProductId = x.ProductId,

            });


            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ADD_Order(Order Order)
        {
           
            var res = await _OrderServices.AddOrders(Order);

            return RedirectToAction("GetallOrder");
        }
        [HttpGet]

        public async Task <IActionResult>  Edit_Order(int id)
        {
            var res = await _OrderServices.GetOrdersByID(id);
            
            return View(res);
        }
       
        [HttpPost]

        public async Task<IActionResult> Edit_Order(Order Order)
        {
            var res1 = _OrderServices.UpdateOrders(Order);

            return RedirectToAction("GetallOrder");
        }
        [HttpGet]

        public async Task<IActionResult> DetailsofOrder(int id)
        {
            var res1 = await _OrderServices.GetOrdersByID(id);

            return View(res1);

        }
        [HttpGet]
        public async Task < IActionResult>  DeleteOrder(int id)
        {
            var res = await _OrderServices.GetOrdersByID(id);

            _OrderServices.DeleteOrders(res);
            
            return RedirectToAction("GetallOrder");

        }




    }



}

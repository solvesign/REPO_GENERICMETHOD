using Microsoft.CodeAnalysis.CSharp.Syntax;
using REPO_GENERICMETHOD.Controllers.IService;
using REPO_GENERICMETHOD.DAL.Iinterfaces;
using REPO_GENERICMETHOD.Models;
namespace REPO_GENERICMETHOD.Controllers.Services
{
    public class OrderServices :IOrderServices
    {

        private readonly IUnitofWork _unitofWork;

        public OrderServices(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
        }

        public async Task<bool> AddOrders(Order Order)
        {
            if (Order != null)
            {
               await _unitofWork._orderRepository.Add(Order);

                var res = _unitofWork.Save();

                if (res > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
               
                               
            }
            return false;
            
        }

        public bool DeleteOrders(Order Order)
        {
            

            if (Order!= null)
            {
                  _unitofWork._orderRepository.Delete(Order);

                _unitofWork.Save();

                return true;
            } 

            return false;


        }        
        

        public async Task<IEnumerable<Order>> GetAllOrders()
        {

            var res = await _unitofWork._orderRepository.GetAll();
           
            return res;
        }

        public async Task<Order> GetOrdersByID(int Id)
        {
            if(Id > 0)
            {
                var res1 = await _unitofWork._orderRepository.GetById(Id);

                if (res1 != null)
                {
                    return res1;
                }
                

            }
            return null; 

                  
            
            
        }

        public async  Task<bool> UpdateOrders(Order order)
        {
            if (order != null)
            {
                var res = await _unitofWork._orderRepository.GetById(order.OrderId);

                if (res != null)
                {
                    res.OrderId = order.OrderId;
                    res.ProductID = order.ProductID;
                    res.Qty = order.Qty;
                    res.PlayerId = order.PlayerId;
                    _unitofWork.Save();
                    return true;



                }
            }

                return false;
            }
           
        }
    }


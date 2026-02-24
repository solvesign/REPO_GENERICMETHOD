using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Update.Internal;
using REPO_GENERICMETHOD.Models;

namespace REPO_GENERICMETHOD.Controllers.IService
{
    public interface IOrderServices
    {
        Task <IEnumerable<Order>> GetAllOrders();
          bool DeleteOrders(Order Orders);
        Task <bool> AddOrders(Order Orders);

        Task  <Order> GetOrdersByID(int Id);

       bool UpdateOrders(Order Orders);

    }
}

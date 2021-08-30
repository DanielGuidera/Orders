using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orders.Service.Order
{
    public interface IOrderService
    {
        Task<Model.Order> GetOrderDetailsForAccountAsync(Model.Order order);
        Task<List<Model.Order>> GetAllOrdersForAccountAsync(Model.Order order);
        Task<string> CreateOrder(Model.Order order);
        Task<string> UpdateOrder(Model.Order order);
    }
}

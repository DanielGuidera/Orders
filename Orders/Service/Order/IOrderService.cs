using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orders.Service.Order
{
    public interface IOrderService
    {
        Task<Model.Order> GetOrderForAccountAsync(int accountId, int orderId);
        Task<List<Model.Order>> GetAllOrdersForAccountAsync(int accountId, int orderId);
        Task<string> CreateOrder(Model.Order order);
        Task<string> UpdateOrder(int accountId, int orderId, Model.Order order);
    }
}

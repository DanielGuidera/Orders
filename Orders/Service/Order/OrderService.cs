using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orders.Service.Order
{
    public class OrderService : IOrderService
    {
        public Task<Model.Order> GetOrderForAccountAsync(int accountId, int orderId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Model.Order>> GetAllOrdersForAccountAsync(int accountId, int orderId)
        {
            throw new NotImplementedException();
        }

        public Task<string> CreateOrder(int accountId, Model.Order order)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateOrder(int accountId, int orderId, Model.Order order)
        {
            throw new NotImplementedException();
        }
    }
}

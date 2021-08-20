using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Orders.DAL;
using Orders.Model;

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

        public async Task<string> CreateOrder(Model.Order order)
        {
            try
            {
                await using var context = new OrderContext();
                await context.Orders.AddAsync(order);
                await context.SaveChangesAsync();                

                return "Success";
            }
            catch
            {
                return null;
            }
        }

        public Task<string> UpdateOrder(int accountId, int orderId, Model.Order order)
        {
            throw new NotImplementedException();
        }
    }
}

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
        public async Task<Model.Order> GetOrderDetailsForAccountAsync(Model.Order order)
        {
            //throw new NotImplementedException();
            var retreivedOrder = GetOrderForAccountAsync(order);
            retreivedOrder.Result.OrderItems = await GetOrderItemsForOrderAsync(retreivedOrder.Result);
            return retreivedOrder.Result;
        }

        private async Task<Model.Order> GetOrderForAccountAsync(Model.Order order)
        {
            await using var context = new OrderContext();
            return context.Orders.SingleOrDefault(o => o.AccountId == order.AccountId && o.OrderId == order.OrderId);
        }

        private async Task<List<Model.OrderItem>> GetOrderItemsForOrderAsync(Model.Order order)
        {
            await using var context = new OrderContext();
            return context.OrderItems.Where(i => i.OrderId == order.OrderId).ToList();
        }

        public Task<List<Model.Order>> GetAllOrdersForAccountAsync(Model.Order order)
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

        public Task<string> UpdateOrder(Model.Order order)
        {
            throw new NotImplementedException();
        }
    }
}

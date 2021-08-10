using System.Collections.Generic;

namespace Orders.Model
{
    public class Order
    {
        public Order(int orderId, int accountId, string address, List<OrderItem> orderItems)
        {
            OrderId = orderId;
            AccountId = accountId;
            Address = address;
            OrderItems = orderItems;
        }

        public int OrderId { get; set; }
        public int AccountId { get; set; }
        public string Address { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
}

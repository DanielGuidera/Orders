using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orders.Model
{
    public class OrderItem
    {
        public OrderItem(int id, Product product, int quantity)
        {
            Id = id;
            Product = product;
            Quantity = quantity;
        }

        public int Id { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}

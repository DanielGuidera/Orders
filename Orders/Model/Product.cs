namespace Orders.Model
{
    public class Product
    {
        public Product(int productId, string name, string description, int quantity)
        {
            ProductId = productId;
            Name = name;
            Description = description;
            Quantity = quantity;
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
    }
}

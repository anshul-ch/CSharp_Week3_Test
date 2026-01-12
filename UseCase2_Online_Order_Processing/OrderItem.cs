namespace CSharp_Week3_Test.UseCase2_Online_Order_Processing
{
    /// <summary>
    /// Composition: Order has OrderItems
    /// </summary>
    public class OrderItem
    {
        public Product Product { get; }
        public int Quantity { get; }

        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public decimal GetTotal()
        {
            return Product.Price * Quantity;
        }
    }
}


using System.Collections.Generic;
using System.Linq;

namespace CSharp_Week3_Test.UseCase2_Online_Order_Processing
{
    /// <summary>
    /// Represents an order aggregate
    /// </summary>
    public class Order
    {
        public int OrderId { get; }
        public Customer Customer { get; }
        public OrderStatus Status { get; private set; }

        // Generic collections
        private List<OrderItem> OrderItems = new List<OrderItem>();
        private List<OrderStatusLog> OrderHistory = new List<OrderStatusLog>();

        public IReadOnlyList<OrderItem> Items => OrderItems;
        public IReadOnlyList<OrderStatusLog> StatusHistory => OrderHistory;

        public Order(int orderId, Customer customer)
        {
            OrderId = orderId;
            Customer = customer;
            Status = OrderStatus.Created;
        }

        public void AddItem(OrderItem item)
        {
            OrderItems.Add(item);
        }

        /// <summary>
        /// Calculates total order value
        /// </summary>
        public decimal CalculateTotal()
        {
            return OrderItems.Sum(i => i.GetTotal());
        }

        // Internal status update
        internal void UpdateStatus(OrderStatus newStatus)
        {
            OrderHistory.Add(new OrderStatusLog(Status, newStatus));
            Status = newStatus;
        }
    }
}


using System;
using System.Collections.Generic;

namespace CSharp_Week3_Test.UseCase2_Online_Order_Processing
{
    /// <summary>
    /// Service responsible for order operations and status transitions
    /// </summary>
    public class OrderService
    {
        public OrderStatusChangedHandler? StatusChanged;

        /// <summary>
        /// Changes order status with validation
        /// </summary>
        public void ChangeStatus(Order order, OrderStatus newStatus)
        {
            // Business rule validation
            if (order.Status == OrderStatus.Cancelled)
            {
                Console.WriteLine("Cancelled orders cannot change status.");
                return;
            }

            if (newStatus == OrderStatus.Shipped && order.Status != OrderStatus.Packed)
            {
                Console.WriteLine("Order must be packed before shipping.");
                return;
            }

            if (newStatus == OrderStatus.Delivered && order.Status != OrderStatus.Shipped)
            {
                Console.WriteLine("Order must be shipped before delivery.");
                return;
            }

            OrderStatus oldStatus = order.Status;
            order.UpdateStatus(newStatus);

            // Notify subscribers
            StatusChanged?.Invoke(order, oldStatus, newStatus);

            Console.WriteLine($"Order {order.OrderId} status changed: {oldStatus} → {newStatus}");
        }
    }
}


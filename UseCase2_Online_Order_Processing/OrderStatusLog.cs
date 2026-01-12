using System;

namespace CSharp_Week3_Test.UseCase2_Online_Order_Processing
{
    /// <summary>
    /// Tracks each order status change
    /// </summary>
    public class OrderStatusLog
    {
        public OrderStatus OldStatus { get; }
        public OrderStatus NewStatus { get; }
        public DateTime ChangedOn { get; }

        public OrderStatusLog(OrderStatus oldStatus, OrderStatus newStatus)
        {
            OldStatus = oldStatus;
            NewStatus = newStatus;
            ChangedOn = DateTime.Now;
        }
    }
}


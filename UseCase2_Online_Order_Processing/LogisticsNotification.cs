using System;

namespace CSharp_Week3_Test.UseCase2_Online_Order_Processing
{
    /// <summary>
    /// Logistics-facing notifications
    /// </summary>
    public static class LogisticsNotification
    {
        public static void Notify(Order order, OrderStatus oldStatus, OrderStatus newStatus)
        {
            if (newStatus == OrderStatus.Shipped)
            {
                Console.WriteLine(
                    $"[Logistics] Dispatch order {order.OrderId}");
            }
        }
    }
}


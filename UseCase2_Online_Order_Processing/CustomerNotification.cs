using System;

namespace CSharp_Week3_Test.UseCase2_Online_Order_Processing
{
    /// <summary>
    /// Customer-facing notifications
    /// </summary>
    public static class CustomerNotification
    {
        public static void Notify(Order order, OrderStatus oldStatus, OrderStatus newStatus)
        {
            Console.WriteLine(
                $"[Customer] Dear {order.Customer.Name}, your order is now {newStatus}");
        }
    }
}


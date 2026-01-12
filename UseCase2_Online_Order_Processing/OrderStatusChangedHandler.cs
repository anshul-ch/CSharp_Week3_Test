namespace CSharp_Week3_Test.UseCase2_Online_Order_Processing
{
    /// <summary>
    /// Delegate for order status change notification
    /// </summary>
    public delegate void OrderStatusChangedHandler(Order order, OrderStatus oldStatus, OrderStatus newStatus);
}


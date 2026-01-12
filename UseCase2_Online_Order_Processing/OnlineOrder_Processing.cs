using System;
using System.Collections.Generic;

namespace CSharp_Week3_Test.UseCase2_Online_Order_Processing
{
    class OnlineOrder_Processing
    {
        static void Main(string[] args)
        {
            // Sample products
            Dictionary<int, Product> products = new Dictionary<int, Product>
            {
                {1, new Product(1, "Laptop", 50000)},
                {2, new Product(2, "Mouse", 500)},
                {3, new Product(3, "Keyboard", 1500)},
                {4, new Product(4, "Monitor", 12000)},
                {5, new Product(5, "Headset", 3000)}
            };

            // Customers
            Customer customer1 = new Customer(1, "Alice");
            Customer customer2 = new Customer(2, "Bob");
            Customer customer3 = new Customer(3, "Charlie");

            // Orders
            Order order1 = new Order(101, customer1);
            order1.AddItem(new OrderItem(products[1], 1));
            order1.AddItem(new OrderItem(products[2], 2));

            OrderService service = new OrderService();
            service.StatusChanged += CustomerNotification.Notify;
            service.StatusChanged += LogisticsNotification.Notify;

            // Status workflow
            service.ChangeStatus(order1, OrderStatus.Paid);
            service.ChangeStatus(order1, OrderStatus.Packed);
            service.ChangeStatus(order1, OrderStatus.Shipped);
            service.ChangeStatus(order1, OrderStatus.Delivered);

            // Print summary
            Console.WriteLine("\n===== ORDER SUMMARY =====");
            Console.WriteLine($"Order Id: {order1.OrderId}");
            Console.WriteLine($"Customer: {order1.Customer.Name}");
            Console.WriteLine($"Total: {order1.CalculateTotal()}");
            Console.WriteLine($"Current Status: {order1.Status}");

            Console.WriteLine("\nStatus Timeline:");
            foreach (var log in order1.StatusHistory)
            {
                Console.WriteLine($"{log.ChangedOn} : {log.OldStatus} → {log.NewStatus}");
            }
        }
    }
}


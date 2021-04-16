using System;

namespace solid_training
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingCartContents shopCartContents = new()
            {
                items = new[] {new ShoppingCart {Price = 1, Quantity = 3},
                               new ShoppingCart {Price = 2, Quantity = 2},
                               new ShoppingCart {Price = 3, Quantity = 1}}
            };

            Order order = new(shopCartContents, 0.7f);
            System.Console.WriteLine($"Order: {order.OrderTotal()}");

        }
    }
}

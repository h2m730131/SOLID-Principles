// namespace solid_training
// {
//     public class ShoppingCart
//     {
//         public float Price;
//         public int Quantity;
//     }
// 
//     public class ShoppingCartContents
//     {
//         public ShoppingCart[] items;
//     }
// 
//     public class Order
//     {
//         private ShoppingCartContents cart;
//         private float salesTax;
// 
//         public Order(ShoppingCartContents cart, float salesTax)
//         {
//             this.cart = cart;
//             this.salesTax = salesTax;
//         }
// 
//         public float OrderTotal()
//         {
//             float cartTotal = 0f;
//             foreach (var cart in cart.items)
//             {
//                 cartTotal += cart.Price * cart.Quantity;
//             }
//             cartTotal *= salesTax;
//             return cartTotal;
//         }
//     }
// }


namespace solid_training
{
    public class ShoppingCart
    {
        public float Price;
        public int Quantity;

        public float Total()
        {
            return Price * Quantity;
        }
    }

    public class ShoppingCartContents
    {
        public ShoppingCart[] items;

        public float Total()
        {
            float total = 0f;
            for (int i = 0; i < items.Length; i++)
            {
                total += items[i].Total();
            }
            return total;
        }
    }

    public class Order
    {
        private ShoppingCartContents cart;
        private float salesTax;

        public Order(ShoppingCartContents cart, float salesTax)
        {
            this.cart = cart;
            this.salesTax = salesTax;
        }

        public float OrderTotal()
        {
            return cart.Total() * salesTax;
        }
    }
}
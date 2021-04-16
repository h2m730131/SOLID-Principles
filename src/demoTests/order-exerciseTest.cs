using Microsoft.VisualStudio.TestTools.UnitTesting;
using solid_training;

namespace solid_trainingTests
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void OrderTotalTest()
        {
            // Arrange
            ShoppingCartContents shopCartContents = new()
            {
                items = new[] {new ShoppingCart {Price = 1, Quantity = 3},
                               new ShoppingCart {Price = 2, Quantity = 2},
                               new ShoppingCart {Price = 3, Quantity = 1}}
            };
            Order target = new(shopCartContents, 0.7f);
            float expected = 7f;

            // Act
            float actual;
            actual = target.OrderTotal();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

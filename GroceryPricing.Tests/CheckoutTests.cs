using System;
using Shouldly;
using Xunit;

namespace GroceryPricing.Tests
{
    public class CheckoutTests
    {
        public Checkout Checkout { get; private set; }

        public CheckoutTests()
        {
            this.Checkout = new Checkout();
        }

        [Fact]
        public void Test()
        {
            this.Checkout.Products.Add(new Product()
            {
                Quantity = 1,
                UnitPrice = 199
            });

            this.Checkout.CalculateNetTotal().ShouldBe(199);
        }
    }
}

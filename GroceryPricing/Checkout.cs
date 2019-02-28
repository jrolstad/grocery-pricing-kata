using System.Collections.Generic;

namespace GroceryPricing
{
    public class Checkout
    {
        public Checkout()
        {
            this.Products = new List<Product>();
        }

        public List<Product> Products { get; }

        public long CalculateNetTotal()
        {
            return -1;
        }
    }
}
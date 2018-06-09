using System.Collections.Generic;

namespace SproutOutClass
{
    public static class TheEvilDatabase
    {
        public static IList<Order> GetRecords()
        {
            return new List<Order>
            {
                new Order() { Quantity = 100, TotalSum = 1250.00M, Product = "Product1", Description = "Description of Product 1"},
                new Order() { Quantity = 50, TotalSum = 685.00M, Product = "Product2", Description = "Description of Product 2" }
            };
        }
    }
}

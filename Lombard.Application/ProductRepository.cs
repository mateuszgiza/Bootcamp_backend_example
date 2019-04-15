using System.Collections.Generic;

namespace Lombard.Application
{
    public class ProductRepository
    {
        public IEnumerable<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product {Name = "Car" },
                new Product {Name = "Book"},
                new Product {Name = "Sandwich"},
                new Product {Name = "Telephone"}
            };
        }

        public void AddProduct(Product product)
        {

        }
    }
}

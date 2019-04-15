using System;

namespace Lombard.Application
{
    public class ProductsService
    {
        private readonly ProductRepository productRepository = new ProductRepository();

        public void AddProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product), "Upewnij sie ze podales dobry produkt");
            }

            productRepository.AddProduct(product);
        }
    }
}

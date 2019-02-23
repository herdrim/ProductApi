using Coffee_mug_test.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coffee_mug_test.Models.Services.Concrete
{
    public class ProductService : IProductService
    {
        IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepository.GetAll();
        }


        public Product GetProductById(Guid id)
        {
            return _productRepository.GetById(id);
        }

        public Guid AddNewProduct(ProductCreateInputModel model)
        {
            Product product = new Product
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                Price = model.Price
            };

            Guid productId = _productRepository.Add(product);

            return productId;
        }

        public void UpdateProduct(ProductUpdateInputModel model)
        {
            Product product = GetProductById(model.Id);
            product.Name = model.Name;
            product.Price = model.Price;
            _productRepository.Update(product);
        }

        public void DeleteProduct(Guid id)
        {
            if (id != Guid.Empty)
            {
                Product product = GetProductById(id);
                _productRepository.Delete(product);
            }
        }
    }
}

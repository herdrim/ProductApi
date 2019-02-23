using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coffee_mug_test.Models.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(Guid id);
        Guid AddNewProduct(ProductCreateInputModel model);
        void UpdateProduct(ProductUpdateInputModel model);
        void DeleteProduct(Guid id);
    }
}

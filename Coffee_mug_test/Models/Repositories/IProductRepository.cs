using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coffee_mug_test.Models.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetById(Guid id);
        Guid Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}

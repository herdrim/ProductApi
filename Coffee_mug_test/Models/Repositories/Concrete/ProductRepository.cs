using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coffee_mug_test.Models.Repositories.Concrete
{
    public class ProductRepository : IProductRepository
    {
        CoffeeMugTestDbContext _ctx;

        public ProductRepository(CoffeeMugTestDbContext context)
        {
            _ctx = context;
        }

        public IEnumerable<Product> GetAll()
            => _ctx.Products;

        public Product GetById(Guid id)
            => _ctx.Products.FirstOrDefault(x => x.Id == id);

        public Guid Add(Product product)
        {
            _ctx.Products.Add(product);
            _ctx.SaveChanges();

            return product.Id;
        }

        public void Update(Product product)
        {
            _ctx.Products.Update(product);
            _ctx.SaveChanges();
        }

        public void Delete(Product product)
        {
            _ctx.Products.Remove(product);
            _ctx.SaveChanges();
        }
    }
}

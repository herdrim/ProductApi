using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coffee_mug_test.Models;
using Coffee_mug_test.Models.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Coffee_mug_test.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
            => _productService.GetAllProducts();


        [HttpGet("{id}")]
        public Product Get(Guid id)
            => _productService.GetProductById(id);

        [HttpPost]
        public Guid Post([FromBody] ProductCreateInputModel model)
        {
            if (ModelState.IsValid)
            {
                return _productService.AddNewProduct(model);
            }
            else
            {                
                ModelState.AddModelError(nameof(ProductCreateInputModel), "Name and Price are required");
                return Guid.Empty;
            }
        }

        [HttpPut]
        public void Put([FromBody] ProductUpdateInputModel model)
        {
            if (ModelState.IsValid)
            {
                _productService.UpdateProduct(model);
            }
            else
            {                
                ModelState.AddModelError(nameof(ProductUpdateInputModel), "Id, Name and Price are required");
            }
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _productService.DeleteProduct(id);
        }
    }
}
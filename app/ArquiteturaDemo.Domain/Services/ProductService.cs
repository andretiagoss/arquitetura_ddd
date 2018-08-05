using ArquiteturaDemo.Domain.Entities;
using ArquiteturaDemo.Domain.Interfaces.Repositories;
using ArquiteturaDemo.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquiteturaDemo.Domain.Services
{
    public class ProductService : ServiceBase<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
            :base(productRepository)
        {
            _productRepository = productRepository;
        }
       
        public IEnumerable<Product> GetByPrice(decimal price)
        {
            return _productRepository.GetByPrice(price);
        }
        public IEnumerable<Product> GetActiveProducts(IEnumerable<Product> products)
        {
            return products.Where(p => p.ActiveProduct(p));
        }
        public IEnumerable<Product> GetOldProducts(IEnumerable<Product> products)
        {
            return products.Where(p => p.OldProduct(p));
        }        
    }
}

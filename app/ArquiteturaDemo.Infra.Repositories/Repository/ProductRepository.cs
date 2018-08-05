using ArquiteturaDemo.Domain.Entities;
using ArquiteturaDemo.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace ArquiteturaDemo.Infra.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public IEnumerable<Product> GetByPrice(decimal price)
        {
            return Context.Set<Product>().Where(x => x.Price == price).ToList();
        }
    }
}

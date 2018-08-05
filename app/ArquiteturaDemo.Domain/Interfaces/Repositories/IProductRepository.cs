using ArquiteturaDemo.Domain.Entities;
using System.Collections.Generic;

namespace ArquiteturaDemo.Domain.Interfaces.Repositories
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        IEnumerable<Product> GetByPrice(decimal price);
    }
}

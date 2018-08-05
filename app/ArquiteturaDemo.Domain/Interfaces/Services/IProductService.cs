using ArquiteturaDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquiteturaDemo.Domain.Interfaces.Services
{
    public interface IProductService : IServiceBase<Product>
    {
        IEnumerable<Product> GetByPrice(decimal price);    
        IEnumerable<Product> GetActiveProducts(IEnumerable<Product> products);
        IEnumerable<Product> GetOldProducts(IEnumerable<Product> products);
    }
}

using ArquiteturaDemo.Domain.Entities;
using System.Collections.Generic;

namespace ArquiteturaDemo.Application.Interfaces
{
    public interface IProductAppService : IAppServiceBase<Product>
    {
        void Register(Product product);
        void UpdateRegister(Product product);
        void DeleteRegister(int productId);
        IEnumerable<Product> GetByPrice(decimal price);
        IEnumerable<Product> GetActiveProducts();
        IEnumerable<Product> GetOldProducts();
    }
}

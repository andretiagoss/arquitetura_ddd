using ArquiteturaDemo.Domain.Entities;
using System.Collections.Generic;

namespace ArquiteturaDemo.Domain.Interfaces.Services
{
    public interface ICategoryService : IServiceBase<Category>
    {
        IEnumerable<Category> GetActiveCategory(IEnumerable<Category> categorys);
    }
}

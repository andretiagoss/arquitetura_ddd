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
    public class CategoryService : ServiceBase<Category>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
            :base(categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IEnumerable<Category> GetActiveCategory(IEnumerable<Category> categorys)
        {
            return categorys.Where(c => c.ActiveCategory(c));
        }
    }
}

using ArquiteturaDemo.Application.Interfaces;
using ArquiteturaDemo.Domain.Entities;
using ArquiteturaDemo.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ArquiteturaDemo.Application
{
    public class CategoryAppService : AppServiceBase<Category>, ICategoryAppService
    {
        private readonly ICategoryService _categoryService;

        public CategoryAppService(ICategoryService categoryService)
            :base(categoryService)
        {
            _categoryService = categoryService;
        }
        public IEnumerable<Category> GetActiveCategorys()
        {            
            return _categoryService.GetActiveCategory(_categoryService.Get());
        }
    }
}

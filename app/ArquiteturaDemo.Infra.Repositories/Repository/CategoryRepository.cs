using ArquiteturaDemo.Domain.Entities;
using ArquiteturaDemo.Domain.Interfaces.Repositories;

namespace ArquiteturaDemo.Infra.Repositories.Repository
{
    public class CategoryRepository: RepositoryBase<Category>, ICategoryRepository
    {
    }
}

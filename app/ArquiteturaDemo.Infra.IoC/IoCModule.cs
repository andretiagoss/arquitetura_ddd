using ArquiteturaDemo.Application;
using ArquiteturaDemo.Application.Interfaces;
using ArquiteturaDemo.Domain.Interfaces.Repositories;
using ArquiteturaDemo.Domain.Interfaces.Services;
using ArquiteturaDemo.Domain.Interfaces.UnitOfWork;
using ArquiteturaDemo.Domain.Services;
using ArquiteturaDemo.Infra.Repositories;
using ArquiteturaDemo.Infra.Repositories.EF;
using ArquiteturaDemo.Infra.Repositories.Repository;
using Ninject.Modules;

namespace ArquiteturaDemo.Infra.IoC
{
    public class IoCModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            Bind<IProductRepository>().To<ProductRepository>();
            Bind<ICategoryRepository>().To<CategoryRepository>();

            Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            Bind<IProductService>().To<ProductService>();
            Bind<ICategoryService>().To<CategoryService>();

            Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            Bind<IProductAppService>().To<ProductAppService>();
            Bind<ICategoryAppService>().To<CategoryAppService>();

            Bind<IUnitOfWork>().To<UnitOfWork>();
            Bind<ContextManager>().ToSelf();            
        }        
    }
}

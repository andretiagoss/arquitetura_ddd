using ArquiteturaDemo.Infra.IoC;
using ProjetoModeloDDD.MVC.AutoMapper;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ArquiteturaDemo.UI.Mvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            IoC.Init();
            DependencyResolver.SetResolver(new IoCDependencyResolver());

            AutoMapperConfig.RegisterMapprings();
        }
    }
}

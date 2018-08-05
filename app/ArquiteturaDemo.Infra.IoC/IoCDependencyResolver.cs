using ArquiteturaDemo.Infra.IoC;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ArquiteturaDemo.Infra.IoC
{
    //Classe criada para resolver a injeção de dependência das controllers
    public class IoCDependencyResolver : IDependencyResolver
    {
        public object GetService(Type serviceType)
        {
            return IoC.Get(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return IoC.GetAll(serviceType);
        }
    }
}

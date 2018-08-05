using ArquiteturaDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquiteturaDemo.Application.Interfaces
{
    public interface ICategoryAppService : IAppServiceBase<Category>
    {
        IEnumerable<Category> GetActiveCategorys();
    }
}

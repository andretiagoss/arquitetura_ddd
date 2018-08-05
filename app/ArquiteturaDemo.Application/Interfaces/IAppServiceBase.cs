using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquiteturaDemo.Application.Interfaces
{
    public interface IAppServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        void Delete(TEntity obj);
        void Delete(int id);
        TEntity Get(int id);
        IEnumerable<TEntity> Get();
        void Update(TEntity obj);
        void Dispose();
        void BeginTransaction();
        void Commit();
    }
}

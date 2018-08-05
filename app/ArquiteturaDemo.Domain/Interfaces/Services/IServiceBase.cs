using System.Collections.Generic;

namespace ArquiteturaDemo.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        TEntity Get(int id);
        IEnumerable<TEntity> Get();
        void Update(TEntity obj);
        void Delete(TEntity obj);
        void Delete(int id);
        void Dispose();
    }
}

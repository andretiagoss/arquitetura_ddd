using System.Collections.Generic;

namespace ArquiteturaDemo.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        void Delete(TEntity obj);
        void Delete(int id);
        TEntity Get(int id);
        IEnumerable<TEntity> Get();
        void Update(TEntity obj);
        void Dispose();
    }
}

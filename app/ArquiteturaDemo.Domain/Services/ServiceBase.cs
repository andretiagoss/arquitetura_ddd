using ArquiteturaDemo.Domain.Interfaces.Repositories;
using ArquiteturaDemo.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquiteturaDemo.Domain.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repositoty)
        {
            _repository = repositoty;
        }
        public void Add(TEntity obj)
        {
            _repository.Add(obj);
        }
        
        public IEnumerable<TEntity> Get()
        {
            return _repository.Get();
        }

        public TEntity Get(int id)
        {
            return _repository.Get(id);
        }

        public void Delete(TEntity obj)
        {
            _repository.Delete(obj);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public void Update(TEntity obj)
        {
            _repository.Update(obj);
        }
        public void Dispose()
        {
            _repository.Dispose();
        }        
    }
}

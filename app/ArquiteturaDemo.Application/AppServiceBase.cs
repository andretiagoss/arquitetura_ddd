using ArquiteturaDemo.Application.Interfaces;
using ArquiteturaDemo.Domain.Interfaces.Services;
using ArquiteturaDemo.Domain.Interfaces.UnitOfWork;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;

namespace ArquiteturaDemo.Application
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private IUnitOfWork _unitOfWork;
        private readonly IServiceBase<TEntity> _serviceBase;

        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;            
        }
        public void Add(TEntity obj)
        {
            _serviceBase.Add(obj);
        }
       
        public void Delete(int id)
        {
            _serviceBase.Delete(id);
        }

        public void Delete(TEntity obj)
        {
            _serviceBase.Delete(obj);
        }
        
        public IEnumerable<TEntity> Get()
        {
            return _serviceBase.Get();
        }

        public TEntity Get(int id)
        {
            return _serviceBase.Get(id);
        }

        public void Update(TEntity obj)
        {
            _serviceBase.Update(obj);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }

        public void BeginTransaction()
        {
            _unitOfWork = ServiceLocator.Current.GetInstance<IUnitOfWork>();
            _unitOfWork.BeginTransaction();
        }
        public void Commit()
        {
            _unitOfWork.Commit();
        }
    }
}

using System.Collections.Generic;
using ArquiteturaDemo.Application.Interfaces;
using ArquiteturaDemo.Domain.Entities;
using ArquiteturaDemo.Domain.Interfaces.Services;
using System;

namespace ArquiteturaDemo.Application
{
    public class ProductAppService : AppServiceBase<Product>, IProductAppService
    {
        private readonly IProductService _productService;
        public ProductAppService(IProductService productService)            
            :base(productService)
        {
            _productService = productService;
        }

        public void Register(Product product)
        {
            try
            {
                // iniciar transação
                this.BeginTransaction();

                // gerenciar as chamadas dos métodos de acordo com a necessidade do método Register
                _productService.Add(product);

                // comitar transação
                this.Commit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.Dispose();
            }       
        }

        public void UpdateRegister(Product product)
        {
            try
            {
                this.BeginTransaction();

                _productService.Update(product);

                this.Commit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.Dispose();
            }
        }

        public void DeleteRegister(int productId)
        {
            try
            {
                this.BeginTransaction();

                _productService.Delete(productId);

                this.Commit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.Dispose();
            }
        }

        public IEnumerable<Product> GetActiveProducts()
        {
            return _productService.GetActiveProducts(_productService.Get());
        }

        public IEnumerable<Product> GetByPrice(decimal price)
        {
            return _productService.GetByPrice(price);
        }

        public IEnumerable<Product> GetOldProducts()
        {
            return _productService.GetOldProducts(_productService.Get());
        }
    }
}

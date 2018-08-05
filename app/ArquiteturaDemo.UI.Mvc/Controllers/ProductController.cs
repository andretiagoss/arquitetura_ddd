using ArquiteturaDemo.Application.Interfaces;
using ArquiteturaDemo.Domain.Entities;
using System.Web.Mvc;
using System.Linq;
using System;
using ArquiteturaDemo.UI.Mvc.ViewModels;
using AutoMapper;
using System.Collections.Generic;

namespace ArquiteturaDemo.UI.Mvc.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductAppService _productAppService;
        private readonly ICategoryAppService _categoryAppService;        

        public ProductController(IProductAppService productAppService, ICategoryAppService categoryAppService)
        {
            _productAppService = productAppService;
            _categoryAppService = categoryAppService;            
        }

        public ActionResult Index()
        {
            var _listProductViewModel = Mapper.Map<IEnumerable<Product>,IEnumerable<ProductViewModels>>(
                _productAppService.GetActiveProducts());
                        
            return View(_listProductViewModel);
        }

        public ActionResult Details(int id)
        {            
            var _productViewModel = Mapper.Map<Product, ProductViewModels>(_productAppService.Get(id));

            return View(_productViewModel);
        }

        public ActionResult Create()
        {
            var _productViewModel = new ProductViewModels();
            _productViewModel.ComboCategory = _categoryAppService.GetActiveCategorys().Select(x => new SelectListItem { Text = x.CategoryName, Value = Convert.ToString(x.CategoryId) });
            return View(_productViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductViewModels productViewModel)
        {
            if (ModelState.IsValid)
            {
                var _productEntity = Mapper.Map<ProductViewModels, Product>(productViewModel);
                _productAppService.Register(_productEntity);
               
                return RedirectToAction("index");
            }

            return View(productViewModel);
        }

        public ActionResult Edit(int id)
        {            
            var _productViewModel = new ProductViewModels();

            _productViewModel = Mapper.Map<Product, ProductViewModels>(_productAppService.Get(id));

            _productViewModel.ComboCategory = _categoryAppService.GetActiveCategorys().Select(x => new SelectListItem { Text = x.CategoryName, Value = Convert.ToString(x.CategoryId) });

            return View(_productViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProductViewModels productViewModels)
        {
            if (ModelState.IsValid)
            {
                var _productEntity = Mapper.Map<ProductViewModels, Product>(productViewModels);
                _productAppService.UpdateRegister(_productEntity);

                return RedirectToAction("Index");
            }
            
            productViewModels.ComboCategory = _categoryAppService.GetActiveCategorys().Select(x => new SelectListItem { Text = x.CategoryName, Value = Convert.ToString(x.CategoryId) });

            return View(productViewModels);
        }

        public ActionResult Delete(int id)
        {            
            var _produtoViewModel = Mapper.Map<Product, ProductViewModels>(_productAppService.Get(id));

            return View(_produtoViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _productAppService.DeleteRegister(id);

            return RedirectToAction("Index");
        }
    }
}
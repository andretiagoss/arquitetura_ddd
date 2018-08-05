using ArquiteturaDemo.Domain.Entities;
using ArquiteturaDemo.UI.Mvc.ViewModels;
using AutoMapper;

namespace ProjetoModeloDDD.MVC.AutoMapper
{
    public class ViewModelToDomainMappginProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappgings"; }
        }

        protected override void Configure()
        {            
            Mapper.CreateMap<Product, ProductViewModels>();
            Mapper.CreateMap<Category, CategoryViewModels>();
        }
    }
}
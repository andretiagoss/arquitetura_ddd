using ArquiteturaDemo.Domain.Entities;
using ArquiteturaDemo.UI.Mvc.ViewModels;
using AutoMapper;

namespace ProjetoModeloDDD.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappgings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ProductViewModels, Product>();
            Mapper.CreateMap<CategoryViewModels, Category>();
        }
    }
}
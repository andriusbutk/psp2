using E_Shop.Contract.Interfaces.FacadeService;
using E_Shop.Entity.InterfacesM;
using E_Shop.Service.Interfaces;
using System;
using System.Threading.Tasks;
using E_Shop.Contract.Dto;
using E_Shop.Contract.Interfaces;
using E_Shop.Entity.Models;
using E_Shop.Entity.ViewModelsM;
using E_Shop.FacadeService.Interfaces;

namespace E_Shop.FacadeService.FacadeService
{
    public class DetailedProductFacadeService : IProductFacadeService
    {
        private readonly IProductCreationTimeService _productCreationTimeService;
        private readonly IPricingService _pricingService;
        private readonly IProductRepository _productRepository;
        private readonly IProductFactoryCreation _productFactoryCreation;
        private readonly IProductDateCompatitionValue _productDateCompatitionValue;

        public DetailedProductFacadeService(IProductCreationTimeService productCreationTimeService, IPricingService pricingService, IProductRepository productRepository, IProductFactoryCreation productFactoryCreation, IProductDateCompatitionValue productDateCompatitionValue)
        {
            _productCreationTimeService = productCreationTimeService;
            _pricingService = pricingService;
            _productRepository = productRepository;
            _productFactoryCreation = productFactoryCreation;
            _productDateCompatitionValue = productDateCompatitionValue;
        }

        public async Task<decimal> GetCompetitionResultOfProduct(ProductViewModelM productModel)
        {
            var product =_productFactoryCreation.FactoryCreate(productModel);
  
            var date = _productCreationTimeService.GetProductCreationDate();

            var price = _productDateCompatitionValue.CalculateCompatitionValueByDate(date);

             await _productRepository.Add(new ProductDto
             {
                 Name = product.Name,
                 Price = price
             });

            return _pricingService.GetValueReview(product.Price);
        }
    }
}

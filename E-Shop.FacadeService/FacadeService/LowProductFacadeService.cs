using E_Shop.Contract.Dto;
using E_Shop.Contract.Interfaces;
using E_Shop.Entity.InterfacesM;
using E_Shop.Entity.ViewModelsM;
using E_Shop.FacadeService.Interfaces;
using E_Shop.Service.Interfaces;
using System.Threading.Tasks;

namespace E_Shop.FacadeService.FacadeService
{
    public class LowProductFacadeService : IProductFacadeService
    {
        private readonly IProductCreationTimeService _productCreationTimeService;
        private readonly IPricingService _pricingService;
        private readonly IProductRepository _productRepository;
        private readonly IProductFactoryCreation _productFactoryCreation;
        private readonly IProductPricingService _productPricingService;

        public LowProductFacadeService(IProductCreationTimeService productCreationTimeService, IPricingService pricingService, IProductRepository productRepository, IProductFactoryCreation productFactoryCreation, IProductPricingService productPricingService)
        {
            _productCreationTimeService = productCreationTimeService;
            _pricingService = pricingService;
            _productRepository = productRepository;
            _productFactoryCreation = productFactoryCreation;
            _productPricingService = productPricingService;
        }

        public async Task<decimal> GetCompetitionResultOfProduct(ProductViewModelM productModel)
        {
            var product = _productFactoryCreation.FactoryCreate(productModel);
            var date = _productCreationTimeService.GetProductCreationDate();

            var pricing = _pricingService.GetValueReview(product.Price);

            await _productRepository.Add(new ProductDto
            {
                Name = product.Name,
                Price = pricing
            });

            return _productPricingService.CalculatePricing(pricing);
        }
    }
}

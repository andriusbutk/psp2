using E_Shop.Service.Interfaces;

namespace E_Shop.Service.Services.ProductPricing
{
    public class ProductPricingService : IProductPricingService
    {
        public decimal CalculatePricing(decimal basePrice)
        {
            return basePrice + 2;
        }
    }
}

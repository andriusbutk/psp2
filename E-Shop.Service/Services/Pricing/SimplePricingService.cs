using E_Shop.Service.Interfaces;

namespace E_Shop.Service.Services.Pricing
{
    public class SimplePricingService : IPricingService
    {
        public int GetValueReview(decimal price)
        {
            if (price > 1000)
                return 8;

            return 9;
        }
    }
}

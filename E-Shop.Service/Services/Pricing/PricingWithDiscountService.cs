using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Shop.Service.Interfaces;

namespace E_Shop.Service.Services.Pricing
{
    public class PricingWithDiscountService : IPricingService
    {
        public int GetValueReview(decimal price)
        {
            if (price > 1000)
                return 2;

            return 6;
        }
    }
}

using E_Shop.Entity.InterfacesM;
using E_Shop.Entity.MModels;
using E_Shop.Entity.ViewModelsM;
using System;

namespace E_Shop.Entity.FacadeCreation
{
    public class ProductFactoryCreation : IProductFactoryCreation
    {
        public IProductM FactoryCreate(ProductViewModelM product)
        {
            if (product.ProductQualityName.Equals("Expensive"))
                return new AdvancedProductM();
            else if (product.ProductQualityName.Equals("Low"))
                return new LowProductM();
            else
                throw new ArgumentException();

        }
    }
}

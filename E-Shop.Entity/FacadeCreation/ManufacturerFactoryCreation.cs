using E_Shop.Entity.InterfacesM;
using E_Shop.Entity.MModels;
using E_Shop.Entity.ViewModelsM;
using System;

namespace E_Shop.Entity.FacadeCreation
{
    public class ManufacturerFactoryCreation : IManufacturerFactoryCreation
    {
        public IManufacturerM FactoryCreate(ManufacturerViewModelM manufacturerType)
        {
            if (manufacturerType.ManufacturerType.Equals("Expensive"))
                return new CheapManufacturerM();
            else if (manufacturerType.ManufacturerType.Equals("Cheap"))
                return new ExpensiveManufacturerM();
            else
                throw new ArgumentException();
        }
    }
}

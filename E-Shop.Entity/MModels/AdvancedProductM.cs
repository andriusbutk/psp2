using E_Shop.Entity.InterfacesM;
using System;

namespace E_Shop.Entity.MModels
{
    public sealed class AdvancedProductM : IProductM
    {
        public int Id { get; set; }
        public string Name { get; set; } = "AdvancedPrice";
        public decimal Price { get; set; }

        private SpecificationM _specificationM;
        public SpecificationM Specification
        {
            get
            {
                _specificationM = new SpecificationM
                {
                    Rate = new Random().Next(6, 10),
                    Description = "Quite Advanced product"
                };

                return _specificationM;
            }
            set => _specificationM = value;
        }
        public IImageM Image { get; set; }
        public IManufacturerM Manufacturer { get; set; }
    }
}

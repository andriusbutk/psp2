using E_Shop.Entity.InterfacesM;

namespace E_Shop.Entity.MModels
{
    public sealed class LowProductM : IProductM
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Low product(poor)";
        public decimal Price { get; set; } = 12.49m;

        private SpecificationM _specificationM;
        public SpecificationM Specification
        {
            get
            {
                _specificationM = new SpecificationM
                {
                    Rate = 4,
                    Description = "Quite Cheap product"
                };

                return _specificationM;
            }
            set => _specificationM = value;
        }
        public IImageM Image { get; set; }
        public IManufacturerM Manufacturer { get; set; }
    }
}

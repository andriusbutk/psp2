using System.Collections.ObjectModel;
using E_Shop.Entity.InterfacesM;

namespace E_Shop.Entity.MModels
{
    public sealed class CheapManufacturerM : IManufacturerM
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Cheap Manufacturer";
        public Collection<IProductM> Products { get; set; }
    }
}

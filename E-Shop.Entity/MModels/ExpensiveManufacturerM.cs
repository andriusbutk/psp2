using System.Collections.ObjectModel;
using E_Shop.Entity.InterfacesM;

namespace E_Shop.Entity.MModels
{
    public sealed class ExpensiveManufacturerM : IManufacturerM
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Expensive manufacturer";
        public Collection<IProductM> Products { get; set; }
    }
}

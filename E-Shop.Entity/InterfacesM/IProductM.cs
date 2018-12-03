using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Shop.Entity.MModels;
using E_Shop.Entity.Models;

namespace E_Shop.Entity.InterfacesM
{
    public interface IProductM
    {
        int Id { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }

        SpecificationM Specification { get; set; }

        IImageM Image { get; set; }

        IManufacturerM Manufacturer { get; set; }
    }
}

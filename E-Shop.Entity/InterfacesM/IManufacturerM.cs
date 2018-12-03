using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Shop.Entity.Models;

namespace E_Shop.Entity.InterfacesM
{
    public interface IManufacturerM
    {
        int Id { get; set; }
        string Name { get; set; }

        Collection<IProductM> Products { get; set; }
    }
}

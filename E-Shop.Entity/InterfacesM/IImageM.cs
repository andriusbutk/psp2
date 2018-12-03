using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shop.Entity.InterfacesM
{
    public interface IImageM
    {
        int Id { get; set; }

        int Length { get; set; }

        int Width { get; set; }

        IProductM Product { get; set; }
    }
}

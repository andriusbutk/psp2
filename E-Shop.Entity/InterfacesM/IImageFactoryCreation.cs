using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Shop.Entity.ViewModelsM;

namespace E_Shop.Entity.InterfacesM
{
    public interface IImageFactoryCreation
    {
        IImageM FactoryCreate(ImageTypeViewModelM imageViewModel);
    }
}

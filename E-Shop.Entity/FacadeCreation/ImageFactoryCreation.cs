using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Shop.Entity.FactoryCreation;
using E_Shop.Entity.InterfacesM;
using E_Shop.Entity.MModels;
using E_Shop.Entity.ViewModelsM;

namespace E_Shop.Entity.FacadeCreation
{
    public class ImageFactoryCreation  : IImageFactoryCreation
    {
        public IImageM FactoryCreate(ImageTypeViewModelM imageViewModel)
        {
            if (imageViewModel.ImageType.Equals("high"))
                return new HighDefinitionFactory().CreateImage();
            else if (imageViewModel.ImageType.Equals("low"))
                return new LowDefinitionFactory().CreateImage();
            else
                throw new ArgumentException("Wrong argument!!!");
        }
    }
}

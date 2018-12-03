using E_Shop.Entity.InterfacesM;
using E_Shop.Entity.MModels;
using E_Shop.Entity.ViewModelsM;

namespace E_Shop.Entity.FactoryCreation
{
    public class HighDefinitionFactory : IFactoryImageCreator
    {
        public IImageM CreateImage()
        {
            return new HighDefinitionImageM();
        }
    }

    public class LowDefinitionFactory : IFactoryImageCreator
    {
        public IImageM CreateImage()
        {
            return new LowDefinitionImageM();
        }
    }
}

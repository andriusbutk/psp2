using E_Shop.Entity.ViewModelsM;
using System.Threading.Tasks;

namespace E_Shop.FacadeService.Interfaces
{
    public interface IManufacturerFacadeService
    {
        Task<string> GetDescriptionOfManufacturer(ManufacturerViewModelM manufacturerModel);
    }
}

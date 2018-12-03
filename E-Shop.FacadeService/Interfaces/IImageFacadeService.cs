using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Shop.Entity.InterfacesM;
using E_Shop.Entity.Models;
using E_Shop.Entity.ViewModelsM;

namespace E_Shop.FacadeService.Interfaces
{
    public interface IImageFacadeService
    {
        Task<decimal> GetDurationOfImageComputation(ImageTypeViewModelM imageViewModel);
        Task<IImageM> GetById(int id);
        Task<Image> AddImage(int width, int length);
    }
}

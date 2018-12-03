using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Shop.Entity.InterfacesM;
using E_Shop.Entity.Models;

namespace E_Shop.Contract.Interfaces.FacadeService
{
    public interface IImageFacadeService
    {
        Task<Image> FindTheLargestImageSize(IImageM image);
    }
}

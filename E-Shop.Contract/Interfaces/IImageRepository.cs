using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Shop.Entity.Models;

namespace E_Shop.Contract.Interfaces
{
    public interface IImageRepository
    {
        Task<Image> Add(Image image);
        Task<Image> GetById(int id);
    }
}

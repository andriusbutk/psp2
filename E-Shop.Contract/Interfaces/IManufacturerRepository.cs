using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Shop.Entity.Models;

namespace E_Shop.Contract.Interfaces
{
    public interface IManufacturerRepository
    {
        Task<Manufacturer> Add(Manufacturer manufacturer);
        Task<Manufacturer> GetById(int id);
        Task<IEnumerable<Manufacturer>> GetAll();
    }
}

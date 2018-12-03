using System.Collections.Generic;
using System.Threading.Tasks;
using E_Shop.Entity.Models;

namespace E_Shop.Contract.Interfaces.FacadeService
{
    public interface IManufacturerFacadeServiceOld
    {
        Task<IEnumerable<Manufacturer>> GetPopularManufacturers();
    }
}

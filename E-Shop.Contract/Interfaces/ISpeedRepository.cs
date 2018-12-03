using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Shop.Entity.Models.PSP;

namespace E_Shop.Contract.Interfaces
{
    public interface ISpeedRepository
    {
        Task<Speed> Add(Speed speed);
        Task<Speed> GetById(int id);
    }
}

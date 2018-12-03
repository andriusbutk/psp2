using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Shop.Contract.Interfaces;
using E_Shop.Entity.Models.PSP;

namespace E_Shop.Repository.Repositories
{
    public class SpeedRepository : ISpeedRepository
    {
        public Task<Speed> Add(Speed speed)
        {
            throw new NotImplementedException();
        }

        public Task<Speed> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

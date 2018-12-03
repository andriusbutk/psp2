using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Shop.Entity.Models.PSP;

namespace E_Shop.Contract.Interfaces
{
    public interface IUserRepository
    {
        Task<User> Add(User user);
        Task<User> GetById(int id);
    }
}

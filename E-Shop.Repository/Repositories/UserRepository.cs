using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Shop.Contract.Interfaces;
using E_Shop.Entity.Models.PSP;

namespace E_Shop.Repository.Repositories
{
    public class UserRepository : IUserRepository
    {
        public Task<User> Add(User user)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

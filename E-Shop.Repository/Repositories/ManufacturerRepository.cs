using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Shop.Contract.Interfaces;
using E_Shop.Entity.Models;
using E_Shop.Repository.DbContext;

namespace E_Shop.Repository.Repositories
{
    public class ManufacturerRepository : IManufacturerRepository
    {
        private readonly ShopContext _dbContext;

        public ManufacturerRepository(ShopContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Manufacturer> Add(Manufacturer manufacturer)
        {
            var manufacturerEntity = _dbContext.Manufacturers.Add(manufacturer);
            await _dbContext.SaveChangesAsync();

            return manufacturerEntity;
        }

        public async Task<Manufacturer> GetById(int id)
        {
            return await _dbContext.Manufacturers.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Manufacturer>> GetAll() => await _dbContext.Manufacturers.ToListAsync();
    }
}

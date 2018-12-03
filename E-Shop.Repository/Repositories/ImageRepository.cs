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
    public class ImageRepository : IImageRepository
    {
        private readonly ShopContext _dbContext;

        public ImageRepository(ShopContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Image> Add(Image image)
        {
            var imageEntity = _dbContext.Images.Add(image);
            await _dbContext.SaveChangesAsync();

            return imageEntity;
        }

        public async Task<Image> GetById(int id)
        {
            return await _dbContext.Images.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}

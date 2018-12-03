using E_Shop.Contract.Dto;
using E_Shop.Contract.Helpers;
using E_Shop.Contract.Interfaces;
using E_Shop.Entity.Enums;
using E_Shop.Entity.Models;
using E_Shop.Repository.DbContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace E_Shop.Repository.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ShopContext _dbContext;

        public ProductRepository(ShopContext dbContext)
        {
            _dbContext = dbContext;
        }

        public PagedList GetAllAsync(SearchFilter filter, QueryParameters parameters)
        {
            return new PagedList()
            {
                Parameters = parameters
            };
        }

        public async Task<Product> GetById(int id)
        {
            return await _dbContext.Products.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Product> Add(ProductDto product)
        {
            var productEntity = _dbContext.Products.Add(new Product
            {
                Name = product.Name,
                Price = product.Price
            });
            await _dbContext.SaveChangesAsync();

            return productEntity;
        }

        private IQueryable<Product> CheckForPaging(QueryParameters parameters, IQueryable<Product> query)
        {
            if (parameters.PageSize > 20)
            {
                parameters.PageSize = 3;
            }

            return query.OrderBy(x => x.Name)
                .Skip((parameters.Page - 1) * parameters.PageSize)
                .Take(parameters.PageSize);
        }

        private int AddManufacturer(string Manufacturer)
        {
            var manufact = new Manufacturer()
            {
                Name = Manufacturer
            };
            _dbContext.Manufacturers.Add(manufact);
            _dbContext.SaveChanges();

            return manufact.Id;
        }

        private int AddSpecification(SpecificationDto specs, int ManufacturerId,
            string osType, int productAdd)
        {
            var specification = new Specification()
            {
                Id = productAdd,
                Camera = specs.Camera,
                Storage = specs.Storage,
                OSType = (SystemType)Enum.Parse(typeof(SystemType), osType),
            };
            _dbContext.Specifications.Add(specification);
            _dbContext.SaveChanges();

            return specification.Id;
        }
    }

    public static class QueryString
    {
        public static IQueryable<Product> ByName(this IQueryable<Product> items, string name = null)
        {
            return !string.IsNullOrEmpty(name) ? items.Where(x => x.Name.Contains(name)) : items;
        }
    }
}

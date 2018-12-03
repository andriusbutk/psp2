using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Shop.Contract.Dto;
using E_Shop.Contract.Helpers;
using E_Shop.Entity.Models;

namespace E_Shop.Contract.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetById(int id);
        Task<Product> Add(ProductDto product);
    }
}

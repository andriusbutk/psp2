using System;
using E_Shop.Entity.InterfacesM;

namespace E_Shop.Entity.MModels
{
    public sealed class LowDefinitionImageM : IImageM
    {
        public int Id { get; set; }
        public int Length { get; set; } = new Random().Next(100, 300);
        public int Width { get; set; } = new Random().Next(100, 300);
        public IProductM Product { get; set; }
    }
}

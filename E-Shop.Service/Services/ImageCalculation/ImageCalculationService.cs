using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Shop.Entity.Enums;
using E_Shop.Service.Interfaces;

namespace E_Shop.Service.Services.ImageCalculation
{
    public class ImageCalculationService : IImageCalculationService
    {
        public decimal CalculateImage(ComputationType computationType)
        {
            if (computationType == ComputationType.ComplexComputation)
                return new Random().Next(500, 600);

            return new Random().Next(200, 700);
        }

        public int CalculateImageWidth()
        {
            return new Random().Next(150, 800);
        }

        public int CalculateImageLength()
        {
            return new Random().Next(150, 800);
        }
    }
}

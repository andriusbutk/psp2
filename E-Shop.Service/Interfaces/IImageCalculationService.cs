using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Shop.Entity.Enums;

namespace E_Shop.Service.Interfaces
{
    public interface IImageCalculationService
    {
        decimal CalculateImage(ComputationType type);
        int CalculateImageWidth();
        int CalculateImageLength();
    }
}

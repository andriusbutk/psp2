using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Shop.Entity.Enums;
using E_Shop.Service.Interfaces;

namespace E_Shop.Service.Services.Computation
{
    public class ComputationService  : IComputationService
    {
        public ComputationType GetComputationType(int length, int width)
        {
            if (length > 500 || width > 500)
                return ComputationType.ComplexComputation;

            return ComputationType.SimpleComputation;
        }
    }
}

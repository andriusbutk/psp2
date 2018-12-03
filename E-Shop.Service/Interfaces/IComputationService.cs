using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Shop.Entity.Enums;
using E_Shop.Entity.InterfacesM;

namespace E_Shop.Service.Interfaces
{
    public interface IComputationService
    {
        ComputationType GetComputationType(int length, int width);
    }
}

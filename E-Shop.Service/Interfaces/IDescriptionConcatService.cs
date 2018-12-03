using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shop.Service.Interfaces
{
    public interface IDescriptionConcatService
    {
        string CreateDescription(string name, decimal points, DateTime date);
    }
}

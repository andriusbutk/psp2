using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Shop.Service.Interfaces;

namespace E_Shop.Service.Services.ProductDate
{
    public class ProductDateCompatitionValue : IProductDateCompatitionValue
    {
        public int CalculateCompatitionValueByDate(DateTime date)
        {
            var totalDays = (DateTime.UtcNow - date).TotalDays;

            if (totalDays > 365)
                return 5;

            else
                return 3;
        }
    }
}

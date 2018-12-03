using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Shop.Contract.Services;

namespace E_Shop.Service.Services.DateServices
{
    public class DateUtcService : IDateService
    {
        public DateTime GetDate() => DateTime.UtcNow;
    }
}

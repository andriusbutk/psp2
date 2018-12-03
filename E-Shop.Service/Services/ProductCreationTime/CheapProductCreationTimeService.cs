﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Shop.Service.Interfaces;

namespace E_Shop.Service.Services.ProductCreationTime
{
    public class CheapProductCreationTimeService : IProductCreationTimeService
    {
        public DateTime GetProductCreationDate() => DateTime.UtcNow.AddMonths(-3);
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Shop.Contract.Services;

namespace E_Shop.Service.Services.ReviewServices
{
    public class SimpleUserReviewService : IReviewService
    {
        public decimal GetUsersReviewPoints()
        {
            var random = new Random();
            var number = random.Next(100);

            return number / 100m;
        }
    }
}

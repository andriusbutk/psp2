using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Shop.Service.Interfaces;

namespace E_Shop.Service.Services.DescriptionConcat
{
    public class DescriptionConcatService  : IDescriptionConcatService
    {
        public string CreateDescription(string name, decimal points, DateTime date)
        {
            return $"Description new: {name} with points: {points}, published: {date}";
        }
    }
}

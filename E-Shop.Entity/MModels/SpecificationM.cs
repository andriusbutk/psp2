using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shop.Entity.MModels
{
    public class SpecificationM
    {
        public string Description { get; set; }

        private decimal _rate;
        public decimal Rate
        {
            get => _rate;

            set
            {
                if (value <= 0 || value > 10)
                    throw new ArgumentException();

                _rate = value;
            }
        }
    }
}

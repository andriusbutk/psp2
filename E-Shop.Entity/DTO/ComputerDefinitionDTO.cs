using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Shop.Entity.Enums;

namespace E_Shop.Entity.DTO
{
    public class ComputerDefinitionDTO
    {
        public int CpuCount { get; set; }

        public decimal HzOfGpu { get; set; }

        public ComputationType ComputationType { get; set; }
    }
}

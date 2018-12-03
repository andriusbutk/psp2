using E_Shop.Entity.DTO;
using E_Shop.Service.Interfaces;

namespace E_Shop.Service.Services.ComputerDefinition
{
    public class ComputerDefinitionService : IComputerDefinitionService
    {
        public ComputerDefinitionDTO GetComputerDefinition()
        {
            return new ComputerDefinitionDTO
            {
                CpuCount = 8,
                HzOfGpu = 2770.49m
            };
        }
    }
}

using E_Shop.Contract.Interfaces;
using E_Shop.Entity.InterfacesM;
using E_Shop.Entity.MModels;
using E_Shop.Entity.Models;
using E_Shop.Entity.ViewModelsM;
using E_Shop.FacadeService.Interfaces;
using E_Shop.Service.Interfaces;
using System.Threading.Tasks;

namespace E_Shop.FacadeService.FacadeService
{
    public class BasicImageFacadeService : IImageFacadeService
    {
        private readonly IComputerDefinitionService _computerDefinitionService;
        private readonly IComputationService _computationService;
        private readonly IImageRepository _imageRepository;
        private readonly IImageFactoryCreation _imageFactoryCreation;
        private readonly IImageCalculationService _imageCalculationService;

        public BasicImageFacadeService(IComputerDefinitionService computerDefinitionService, IComputationService computationService, IImageRepository imageRepository, IImageFactoryCreation imageFactoryCreation, IImageCalculationService imageCalculationService)
        {
            _computerDefinitionService = computerDefinitionService;
            _computationService = computationService;
            _imageRepository = imageRepository;
            _imageFactoryCreation = imageFactoryCreation;
            _imageCalculationService = imageCalculationService;
        }

        public async Task<decimal> GetDurationOfImageComputation(ImageTypeViewModelM imageViewModel)
        {
            var image = _imageFactoryCreation.FactoryCreate(imageViewModel);
            var computationType = _computationService.GetComputationType(image.Length, image.Width);

            var computer = _computerDefinitionService.GetComputerDefinition();

            computer.ComputationType = computationType;

            await _imageRepository.Add(new Image(image.Length, image.Width));

            return _imageCalculationService.CalculateImage(computationType);
        }

        public async Task<IImageM> GetById(int id)
        {
            var image = await _imageRepository.GetById(id);

            await _imageRepository.Add(new Image(1, 1)); //log

            return new HighDefinitionImageM
            {
                Length = _imageCalculationService.CalculateImageLength(),
                Width = _imageCalculationService.CalculateImageWidth()
            };
        }

        public async Task<Image> AddImage(int width, int length)
        {
            var image = await _imageRepository.Add(new Image(_imageCalculationService.CalculateImageLength(), _imageCalculationService.CalculateImageWidth()));

            return image;
        }
    }
}

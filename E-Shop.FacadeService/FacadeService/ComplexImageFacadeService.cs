using E_Shop.Entity.Enums;
using E_Shop.Entity.InterfacesM;
using E_Shop.FacadeService.Interfaces;
using E_Shop.Service.Interfaces;
using System;
using System.Threading.Tasks;
using E_Shop.Contract.Interfaces;
using E_Shop.Entity.MModels;
using E_Shop.Entity.Models;
using E_Shop.Entity.ViewModelsM;
using E_Shop.Integration.Interfaces;

namespace E_Shop.FacadeService.FacadeService
{
    public class ComplexImageFacadeService : IImageFacadeService
    {
        private readonly IComputerDefinitionService _computerDefinitionService;
        private readonly IComputationService _computationService;
        private readonly IImageRepository _imageRepository;
        private readonly IEmailSenderService _emailSenderService;
        private readonly IImageFactoryCreation _imageFactoryCreation;
        private readonly IImageCalculationService _imageCalculationService;

        public ComplexImageFacadeService(IComputerDefinitionService computerDefinitionService, IComputationService computationService, IImageRepository imageRepository, IEmailSenderService emailSenderService, IImageFactoryCreation imageFactoryCreation, IImageCalculationService imageCalculationService)
        {
            _computerDefinitionService = computerDefinitionService;
            _computationService = computationService;
            _imageRepository = imageRepository;
            _emailSenderService = emailSenderService;
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

            _emailSenderService.SendMessage(image.Id.ToString());

            return _imageCalculationService.CalculateImage(computationType);
        }

        public async Task<IImageM> GetById(int id)
        {
            var image = await _imageRepository.GetById(id);

            return new LowDefinitionImageM
            {
                Length = new Random().Next(150, 800),
                Width = new Random().Next(150, 800)
            };
        }

        public async Task<Image> AddImage(int width, int length)
        {
            return await _imageRepository.Add(new Image(width + 100, length + 200));
        }
    }
}

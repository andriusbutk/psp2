using System.Threading.Tasks;
using E_Shop.Contract.Interfaces;
using E_Shop.Contract.Services;
using E_Shop.Entity.InterfacesM;
using E_Shop.Entity.Models;
using E_Shop.Entity.ViewModelsM;
using E_Shop.FacadeService.Interfaces;
using E_Shop.Service.Interfaces;

namespace E_Shop.FacadeService.FacadeService
{
    public class NewDescriptionManufacturerService : IManufacturerFacadeService
    {
        private readonly IReviewService _reviewService;
        private readonly IDateService _dateService;
        private readonly IManufacturerRepository _manufacturerRepository;
        private readonly IManufacturerFactoryCreation _manufacturerFactoryCreation;
        private readonly IDescriptionConcatService _descriptionConcatService;

        public NewDescriptionManufacturerService(IReviewService reviewService, IDateService dateService, IManufacturerRepository manufacturerRepository, IManufacturerFactoryCreation manufacturerFactoryCreation, IDescriptionConcatService descriptionConcatService)
        {
            _reviewService = reviewService;
            _dateService = dateService;
            _manufacturerRepository = manufacturerRepository;
            _manufacturerFactoryCreation = manufacturerFactoryCreation;
            _descriptionConcatService = descriptionConcatService;
        }

        public async Task<string> GetDescriptionOfManufacturer(ManufacturerViewModelM manufacturerModel)
        {
            var manufacturer = _manufacturerFactoryCreation.FactoryCreate(manufacturerModel);
            var points = _reviewService.GetUsersReviewPoints();
            var date = _dateService.GetDate();
            await _manufacturerRepository.Add(new Manufacturer
            {
                Name = manufacturer.Name
            });

            return _descriptionConcatService.CreateDescription(manufacturer.Name, points, date);
        }
    }
}

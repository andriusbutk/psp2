using System;
using E_Shop.Contract.Interfaces;
using E_Shop.Contract.Interfaces.FacadeService;
using E_Shop.Contract.Services;
using E_Shop.Entity.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Shop.FacadeService.FacadeService
{
    public class ManufacturerFacadeService : IManufacturerFacadeServiceOld
    {
        private readonly IDateService _dateService;
        private readonly IReviewService _reviewService;
        private readonly IManufacturerRepository _manufacturerRepository;

        public ManufacturerFacadeService(IDateService dateService, IReviewService reviewService, IManufacturerRepository manufacturerRepository)
        {
            _dateService = dateService;
            _reviewService = reviewService;
            _manufacturerRepository = manufacturerRepository;
        }
        public async Task<IEnumerable<Manufacturer>> GetPopularManufacturers()
        {
            var date = _dateService.GetDate();

            var reviewPoints = _reviewService.GetUsersReviewPoints();

            var manufacturers = await _manufacturerRepository.GetAll();

            var random = new Random();
            var numberFrom = random.Next(manufacturers.Count());

            return manufacturers.Skip(numberFrom).Take(manufacturers.Count() - numberFrom);
        }
    }
}

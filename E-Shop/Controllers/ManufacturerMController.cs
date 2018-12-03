using E_Shop.Entity.InterfacesM;
using E_Shop.Entity.ViewModelsM;
using E_Shop.FacadeService.Interfaces;
using System.Threading.Tasks;
using System.Web.Http;

namespace E_Shop.Controllers
{
    [RoutePrefix("api/manufacturerM")]
    public class ManufacturerMController : ApiController
    {
        private readonly IManufacturerFacadeService _manufacturerFacadeService;
        private readonly IManufacturerFactoryCreation _manufacturerFactoryCreation;

        public ManufacturerMController(IManufacturerFacadeService manufacturerFacadeService, IManufacturerFactoryCreation manufacturerFactoryCreation)
        {
            _manufacturerFacadeService = manufacturerFacadeService;
            _manufacturerFactoryCreation = manufacturerFactoryCreation;
        }

        [Route("description")]
        [HttpPost]
        public async Task<IHttpActionResult> GetNewestDescriptionOfManufacturer([FromBody] ManufacturerViewModelM manufacturerViewModel) => Ok(await _manufacturerFacadeService.GetDescriptionOfManufacturer(manufacturerViewModel));
    }
}

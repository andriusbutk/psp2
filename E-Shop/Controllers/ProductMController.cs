using System.Threading.Tasks;
using E_Shop.Contract.Interfaces.FacadeService;
using E_Shop.Entity.InterfacesM;
using E_Shop.Entity.ViewModelsM;
using System.Web.Http;
using E_Shop.FacadeService.Interfaces;

namespace E_Shop.Controllers
{
    [RoutePrefix("api/productM")]
    public class ProductMController : ApiController
    {
        private readonly IProductFacadeService _productFacadeService;

        public ProductMController(IProductFacadeService productFacadeService, IProductFactoryCreation productFactoryCreation)
        {
            _productFacadeService = productFacadeService;
        }

        [Route("competition")]
        [HttpPost]
        public async Task<IHttpActionResult> GetCompetitionResultOfProduct([FromBody]ProductViewModelM productQualityModel) => Ok(await _productFacadeService.GetCompetitionResultOfProduct(productQualityModel));
    }
}

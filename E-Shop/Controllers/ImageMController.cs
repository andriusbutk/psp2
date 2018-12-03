using E_Shop.Entity.FacadeCreation;
using E_Shop.Entity.ViewModelsM;
using E_Shop.FacadeService.Interfaces;
using System.Threading.Tasks;
using System.Web.Http;

namespace E_Shop.Controllers
{
    [RoutePrefix("api/imageM")]
    public class ImageMController : ApiController
    {
        private readonly IImageFacadeService _imageFacadeService;

        public ImageMController(IImageFacadeService imageFacadeService)
        {
            _imageFacadeService = imageFacadeService;
        }

        [Route("process")]
        [HttpPost]
        public async Task<IHttpActionResult> GetImageProcessDurationPost([FromBody]ImageTypeViewModelM imageViewModel) => Ok(await _imageFacadeService.GetDurationOfImageComputation(imageViewModel));

        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id) => Ok(await _imageFacadeService.GetById(id));
    }
}

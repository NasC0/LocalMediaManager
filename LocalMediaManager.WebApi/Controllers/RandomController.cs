using System.Threading.Tasks;
using System.Web.Http;

namespace LocalMediaManager.WebApi.Controllers
{
    public class RandomController : ApiController
    {
        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            return Ok("teehee");
        }
    }
}

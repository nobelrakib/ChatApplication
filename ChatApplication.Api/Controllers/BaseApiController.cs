using ChatApplication.API.Filter;
using Microsoft.AspNetCore.Mvc;

namespace ChatApplication.API.Controllers
{
    [ServiceFilter(typeof(LogUserActivity))]
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {

    }
   
}
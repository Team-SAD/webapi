using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Planner.Client.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [EnableCors("public")]
    public class ApiBaseController : ControllerBase
    {
        
    }
}
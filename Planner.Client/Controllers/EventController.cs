using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Planner.Storage;

namespace Planner.Client.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;
        public EventController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetEvents()
        {
            var events = await _unitOfWork.Events.SelectEventsAsync();
            return Ok(events);
        }
        
    }
}
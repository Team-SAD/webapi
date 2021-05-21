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
        public IActionResult GetEvents()
        {
            var events = _unitOfWork.Events.SelectEventsAsync();
            return Ok(events);
        }
        
    }
}
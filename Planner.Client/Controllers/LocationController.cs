using Microsoft.AspNetCore.Mvc;
using Planner.Storage;

namespace Planner.Client.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LocationController : ControllerBase
    {
 
    

        private readonly UnitOfWork _unitOfWork;
        public LocationController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult GetEvents()
        {
            var locations = _unitOfWork.Locations.SelectLocationsAsync();
            return Ok(locations);
        }
        
    
    }
}
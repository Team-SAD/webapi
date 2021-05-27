using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Planner.Storage;

namespace Planner.Client.Controllers
{

  public class LocationController : ApiBaseController
  {



    private readonly UnitOfWork _unitOfWork;
    public LocationController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public async Task<IActionResult> GetEvents()
    {
      var locations = await _unitOfWork.Locations.SelectLocationsAsync();
      return Ok(locations);
    }


  }
}
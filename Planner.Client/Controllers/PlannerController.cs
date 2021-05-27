using System.Threading.Tasks;
using Planner.Client.Controllers;
using Microsoft.AspNetCore.Mvc;
using Planner.Storage;

namespace Planner.Client.Controllers
{

  public class PlannerController : ApiBaseController
  {
    private readonly UnitOfWork _unitOfWork;
    public PlannerController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public async Task<IActionResult> GetPlanners()
    {
      var planners = await _unitOfWork.Planners.SelectPlannersAsync();
      return Ok(planners);
    }

  }
}
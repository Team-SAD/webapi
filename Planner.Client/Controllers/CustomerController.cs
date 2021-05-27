using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Planner.Storage;

namespace Planner.Client.Controllers
{

  public class CustomerController : ApiBaseController
  {
    private readonly UnitOfWork _unitOfWork;
    public CustomerController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;

    }

    [HttpGet]
    public async Task<IActionResult> GetCustomers()
    {
      var customers = await _unitOfWork.Customers.SelectCustomersAsync();

      return Ok(customers);
    }


  }
}
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

        [HttpGet("users")]
        public async Task<IActionResult> GetCustomers()
        {
            var customers = await _unitOfWork.AppUsers.SelectCustomersAsync();

            return Ok(customers);
        }

        [HttpGet("user")]
        public async Task<IActionResult> GetCustomerByName(string name)
        {
           var customer = await _unitOfWork.AppUsers.GetCustomerByName(name);

            return Ok(customer);
        }

       

    }
}
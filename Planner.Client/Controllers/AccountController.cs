using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Planner.Domain.DTO;
using Planner.Domain.Models;
using Planner.Storage;

namespace Planner.Client.Controllers
{
  public class AccountController : ApiBaseController
  {


    private readonly UnitOfWork _unitOf;

    public AccountController(UnitOfWork unitOf)
    {
      _unitOf = unitOf;


    }

    [HttpPost("register")]
    public async Task<ActionResult<Customer>> Register(RegisterDto registerDto)
    {
      var user = new Customer() { Name = registerDto.Name };
      _unitOf.Customers.Create(user);
      await _unitOf.Save();
      return user;

    }

    [HttpPost("login")]
    public async Task<ActionResult<Customer>> Login(LoginDto loginDto)
    {
      var user = await _unitOf.Customers.GetCustomerByName(loginDto.Name);

      if (user == null) return Unauthorized("Invalid User");

      return user;


    }
  }
}
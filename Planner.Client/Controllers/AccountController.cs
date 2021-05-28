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
        public async Task<ActionResult<AppUser>> Register(RegisterDto registerDto)
        {
            var user = new AppUser() { Name = registerDto.Name };
            _unitOf.AppUsers.Create(user);
            await _unitOf.Save();
            return user;

        }

        [HttpPost("login")]
        public async Task<ActionResult<AppUser>> Login(LoginDto loginDto)
        {
            var user = await _unitOf.AppUsers.GetCustomerByName(loginDto.Name);

            if(user == null) return Unauthorized("Invalid User");

            return user;


        }
    }
}
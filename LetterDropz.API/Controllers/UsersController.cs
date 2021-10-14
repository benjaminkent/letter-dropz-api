using System;
using System.Threading.Tasks;
using LetterDropz.API.Models.Users;
using LetterDropz.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace LetterDropz.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly UsersService _usersService;

        public UsersController(UsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(UserDto userDto)
        {
            var user = await _usersService.CreateUser(userDto);

            return Ok(user);
        }
    }
}

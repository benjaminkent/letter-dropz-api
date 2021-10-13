using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LetterDropz.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> CreateUser(User user)
        {

        }
    }
}

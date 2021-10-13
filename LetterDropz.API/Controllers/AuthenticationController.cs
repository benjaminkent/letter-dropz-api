using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LetterDropz.API.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LetterDropz.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthenticationController : Controller
    {
        [HttpGet]
        public IActionResult GetStr()
        {
            return Ok("got it");
        }
    }
}
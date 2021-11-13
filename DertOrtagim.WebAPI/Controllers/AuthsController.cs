using Core.Utilities.Results.Abstract;
using DertOrtagim.Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DertOrtagim.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthsController : ControllerBase
    {
        [HttpPost]
        public IActionResult Login(string eMail,string password)
        {
            return Ok("TEST");
        }

        [HttpPost]
        public IActionResult Register(UserForRegisterDto userForRegisterDto)
        {
            throw new NotImplementedException();

        }
        [HttpGet]
        public IActionResult Test()
        {
            return Ok("TEST");
        }
    }
}

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
    public class PostsController : ControllerBase
    {
        [HttpPost]
        public IActionResult GetPosts()
        {
            return BadRequest(result.Message);
            return (IDataResult<List<PostForReturnDto>>);
        }

        [HttpPost]
        public IActionResult GetPostsByUserId(int userId)
        {
            return BadRequest(result.Message);
            return (IDataResult<List<PostForReturnDto>>);
        }

    }
}

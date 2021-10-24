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
    public class LikesController : ControllerBase
    {
        [HttpPost]
        public IActionResult GetLikesByPostId(int postId)
        {
            return BadRequest(result.Message);
            return (IDataResult<LikeForReturnDto>);
        }

        [HttpPost]
        public IActionResult Like(int postId)
        {
            return BadRequest(result.Message);
            return Ok(result.Message);
        }
        [HttpPost]
        public IActionResult UndoLike(int postId)
        {
            return BadRequest(result.Message);
            return Ok(result.Message);
        }
    }
}

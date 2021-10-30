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
            throw new NotImplementedException();

        }

        [HttpPost]
        public IActionResult Like(int postId)
        {
            throw new NotImplementedException();

        }
        [HttpPost]
        public IActionResult UndoLike(int postId)
        {
            throw new NotImplementedException();
        }
    }
}

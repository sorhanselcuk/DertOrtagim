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
    public class CommentsController : ControllerBase
    {
        [HttpPost]
        public IActionResult GetCommentsByPostId(int postId)
        {
            throw new NotImplementedException();

        }

        [HttpPost]
        public IActionResult Comment()
        {
            throw new NotImplementedException();

        }
    }
}

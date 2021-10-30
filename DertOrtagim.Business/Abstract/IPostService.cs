using Core.Utilities.Results.Abstract;
using DertOrtagim.Entities.DBModels;
using DertOrtagim.Entities.DTOs;
using System.Collections.Generic;

namespace DertOrtagim.Business.Abstract
{
    public interface IPostService
    {
        IResult AddPost(Post post);
        IResult RemovePost(int postId);
        IDataResult<PostForReturnDto> GetPostById(int postId);
        IDataResult<List<PostForReturnDto>> GetPostByUserId(int userId);
    }
}

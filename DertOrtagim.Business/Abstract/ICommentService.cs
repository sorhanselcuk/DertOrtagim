using Core.Utilities.Results.Abstract;
using DertOrtagim.Entities.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DertOrtagim.Business.Abstract
{
    public interface ICommentService
    {
        IResult AddComment(Comment comment);
        IResult RemoveComment(int commentId);
        IDataResult<List<Comment>> GetCommentsByPostId(int postId);
        IDataResult<int> GetCommentCountByPostId(int postId);
    }
}

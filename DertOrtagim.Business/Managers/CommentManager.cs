using Core.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DertOrtagim.Business.Abstract;
using DertOrtagim.DataAccess.Abstract;
using DertOrtagim.Entities.DBModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DertOrtagim.Business.Managers
{
    public class CommentManager : ICommentService
    {
        private ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public IResult AddComment(Comment comment)
        {
            _commentDal.Add(comment);
            return new SuccessResult(Messages.Success);
        }

        public IDataResult<int> GetCommentCountByPostId(int postId)
        {
            var count = _commentDal.GetAll(c=>c.PostId == postId).Count;
            return new SuccessDataResult<int>(count,Messages.Success);
        }

        public IDataResult<List<Comment>> GetCommentsByPostId(int postId)
        {
            var comments = _commentDal.GetAll(c=>c.PostId == postId);
            return new SuccessDataResult<List<Comment>>(comments,Messages.Success);
        }

        public IResult RemoveComment(int commentId)
        {
            _commentDal.Delete(new Comment { Id = commentId });
            return new SuccessResult(Messages.Success);
        }
    }
}

using Core.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DertOrtagim.Business.Abstract;
using DertOrtagim.DataAccess.Abstract;
using DertOrtagim.Entities.DBModels;
using DertOrtagim.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DertOrtagim.Business.Managers
{
    public class LikeManager : ILikeService
    {
        private ILikeDal _likeDal;

        public LikeManager(ILikeDal likeDal)
        {
            _likeDal = likeDal;
        }

        public IResult AddLike(Like like)
        {
            _likeDal.Add(like);
            return new SuccessResult(Messages.Success);
        }

        public IDataResult<int> GetLikeCountByPostId(int postId)
        {
            var count = _likeDal.GetAll(l => l.PostId == postId).Count;
            return new SuccessDataResult<int>(count, Messages.Success);
        }

        public IDataResult<LikeForReturnDto> GetLikedUsersByPostId(int postId)
        {
            var result = new LikeForReturnDto {
                PostId = postId,
                UserIds = _likeDal.GetAll(l => l.PostId == postId).Select(l => l.UserId).ToList() 
            };
            return new SuccessDataResult<LikeForReturnDto>(result,Messages.Success);
        }

        public IResult RemoveLike(int postId)
        {
            _likeDal.Delete(new Like { PostId = postId });
            return new SuccessResult(Messages.Success);
        }
    }
}

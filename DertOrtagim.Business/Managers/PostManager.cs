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

namespace DertOrtagim.Business.Managers
{
    public class PostManager : IPostService
    {
        private IPostDal _postDal;
        private ICommentService _commentService;
        private ILikeService _likeService;
        private IProfilePictureService _profilePictureService;
        public PostManager(IPostDal postDal, ICommentService commentService, ILikeService likeService, IProfilePictureService profilePictureService)
        {
            _postDal = postDal;
            _commentService = commentService;
            _likeService = likeService;
            _profilePictureService = profilePictureService;
        }

        public IResult AddPost(Post post)
        {
            _postDal.Add(post);
            return new SuccessResult(Messages.Success);
        }

        public IDataResult<PostForReturnDto> GetPostById(int postId)
        {
            var post = _postDal.Get(p=>p.Id == postId);
            var result = new PostForReturnDto {
                Id = postId,
                CommentCount = _commentService.GetCommentCountByPostId(postId).Data,
                LikeCount = _likeService.GetLikeCountByPostId(postId).Data,
                Date = post.Date,
                Text = post.Text,
                UserId = post.UserId,
                ProfilePicture = _profilePictureService.GetProfilePictureByUserId(post.UserId).Data.Data
            };
            return new SuccessDataResult<PostForReturnDto>(result,Messages.Success);
        }

        public IDataResult<List<PostForReturnDto>> GetPostByUserId(int userId)
        {
            var posts = _postDal.GetAll(p=>p.UserId == userId);
            var result = new List<PostForReturnDto>();
            var profilePicture = _profilePictureService.GetProfilePictureByUserId(posts[0].UserId).Data.Data;
            foreach (var post in posts)
            {
                result.Add(new PostForReturnDto {
                    Id = post.Id,
                    CommentCount = _commentService.GetCommentCountByPostId(post.Id).Data,
                    LikeCount = _likeService.GetLikeCountByPostId(post.Id).Data,
                    Date = post.Date,
                    Text = post.Text,
                    UserId = post.UserId,
                    ProfilePicture = profilePicture
                });
            }
            return new SuccessDataResult<List<PostForReturnDto>>(result,Messages.Success);
        }

        public IResult RemovePost(int postId)
        {
            _postDal.Delete(new Post { Id = postId });
            return new SuccessResult(Messages.Success);
        }
    }
}

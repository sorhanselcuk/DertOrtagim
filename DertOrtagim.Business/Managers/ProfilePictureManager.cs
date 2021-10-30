using Core.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DertOrtagim.Business.Abstract;
using DertOrtagim.DataAccess.Abstract;
using DertOrtagim.Entities.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DertOrtagim.Business.Managers
{
    public class ProfilePictureManager : IProfilePictureService
    {
        private IProfilePictureDal _profilePictureDal;
        private IUserService _userService;

        public ProfilePictureManager(IProfilePictureDal profilePictureDal, IUserService userService)
        {
            _profilePictureDal = profilePictureDal;
            _userService = userService;
        }

        public IResult AddProfilePicture(ProfilePicture profilePicture)
        {
            _profilePictureDal.Add(profilePicture);
            return new SuccessResult(Messages.Success);
        }

        public IDataResult<ProfilePicture> GetProfilePictureByUserId(int userId)
        {
            var profilePicture = _profilePictureDal.Get(p=>p.UserId == userId);
            return new SuccessDataResult<ProfilePicture>(profilePicture,Messages.Success);
        }

        public IDataResult<ProfilePicture> GetProfilePictureByUserName(string userName)
        {
            var userId = _userService.GetUserIdByUserName(userName).Data;
            var profilePicture = _profilePictureDal.Get(p => p.UserId == userId);
            return new SuccessDataResult<ProfilePicture>(profilePicture, Messages.Success);
        }

        public IResult RemoveProfilePicture(int profilePictureId)
        {
            _profilePictureDal.Delete(new ProfilePicture { Id = profilePictureId });
            return new SuccessResult(Messages.Success);
        }
    }
}

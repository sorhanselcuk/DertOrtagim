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
    public class ProfileManager : IProfileService
    {
        private IProfileDal _profileDal;
        private IUserService _userService;

        public ProfileManager(IProfileDal profileDal,IUserService userService)
        {
            _profileDal = profileDal;
            _userService = userService;
        }

        public IResult AddProfile(Profile profile)
        {
            _profileDal.Add(profile);
            return new SuccessResult(Messages.Success);
        }

        public IDataResult<Profile> GetProfileByUserId(int userId)
        {
            var profile = _profileDal.Get(p => p.UserId == userId);
            return new SuccessDataResult<Profile>(profile, Messages.Success);
        }

        public IDataResult<Profile> GetProfileByUserName(string userName)
        {
            var userId = _userService.GetUserIdByUserName(userName).Data;
            var profile = _profileDal.Get(p => p.UserId == userId);
            return new SuccessDataResult<Profile>(profile, Messages.Success);
        }

        public IResult RemoveProfile(int profileId)
        {
            _profileDal.Delete(new Profile { Id = profileId });
            return new SuccessResult(Messages.Success);
        }
    }
}

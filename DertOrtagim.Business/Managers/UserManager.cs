using Core.Constants;
using Core.Entities.SecurityModels;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DertOrtagim.Business.Abstract;
using DertOrtagim.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DertOrtagim.Business.Managers
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.Success);
        }

        public User GetByMail(string email)
        {
            var result = _userDal.Get(u=>u.EMail == email);
            return result;
        }

        public User GetByUserName(string userName)
        {
            var result = _userDal.Get(u => u.UserName == userName);
            return result;
        }

        public User GetUserById(int userId)
        {
            var result = _userDal.Get(u => u.Id == userId);
            return result;
        }
    }
}

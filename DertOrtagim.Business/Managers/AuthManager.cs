using Core.Constants;
using Core.Entities.SecurityModels;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;
using DertOrtagim.Business.Abstract;
using DertOrtagim.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DertOrtagim.Business.Managers
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;

        public AuthManager(IUserService userService, ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
        }

        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new User
            {
                EMail=userForRegisterDto.EMail,
                UserName=userForRegisterDto.UserName,
                FirstName=userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                DateOfBirth = userForRegisterDto.DateOfBirth,
                Sex=userForRegisterDto.Sex,
                PasswordHash=passwordHash,
                PasswordSalt=passwordSalt
            };
            _userService.Add(user);
            return new SuccessDataResult<User>(user, Messages.Success);
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByUserName(userForLoginDto.UserName);
            if (userToCheck == null)
            {
                return new ErrorDataResult<User>(Messages.ThereIsNoSuchUser);
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return new ErrorDataResult<User>(Messages.WrongPassword);
            }

            return new SuccessDataResult<User>(userToCheck, Messages.Success);
        }

        public IResult UserExists(string email)
        {
            if (_userService.GetByMail(email) != null)
            {
                return new ErrorResult(Messages.UserHasAlreadyExists);
            }
            return new SuccessResult();
        }

        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            var accessToken = _tokenHelper.CreateToken(user, null);
            return new SuccessDataResult<AccessToken>(accessToken, Messages.TokenWasCreated);
        }
    }
}

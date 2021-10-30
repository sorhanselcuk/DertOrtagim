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
    public class UserRateManager : IUserRateService
    {
        private IUserRateDal _userRateDal;
        private IUserService _userService;

        public UserRateManager(IUserRateDal userRateDal, IUserService userService)
        {
            _userRateDal = userRateDal;
            _userService = userService;
        }

        public IResult AddPoint(UserRateForAddDto userRateForAddDto)
        {
            throw new NotImplementedException();

        }

        public IResult AddRate(UserRate userRate)
        {
            throw new NotImplementedException();
        }

        public IDataResult<double> GetUserRateByUserId(int userId)
        {
            var rate = _userRateDal.Get(r => r.UserId == userId);
            double ratePoint = 0;
            try
            {
                ratePoint = Convert.ToDouble(rate.Rate) / Convert.ToDouble(rate.RateCount);
            }
            catch (DivideByZeroException exception)
            {

            }

            return new SuccessDataResult<double>(ratePoint, Messages.Success);
        }

        public IDataResult<double> GetUserRateByUserName(string userName)
        {
            var userId = _userService.GetUserIdByUserName(userName).Data;
            return GetUserRateByUserId(userId);
        }

        public IDataResult<int> GetUserRateCountByUserId(int userId)
        {
            var rateCount = _userRateDal.Get(r => r.UserId == userId).RateCount;
            return new SuccessDataResult<int>(rateCount,Messages.Success);
        }

        public IDataResult<int> GetUserRateCountByUserName(string userName)
        {
            var userId = _userService.GetUserIdByUserName(userName).Data;
            var rateCount = _userRateDal.Get(r => r.UserId == userId).RateCount;
            return new SuccessDataResult<int>(rateCount, Messages.Success);
        }
    }
}

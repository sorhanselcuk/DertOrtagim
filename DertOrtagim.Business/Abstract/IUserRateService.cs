using Core.Utilities.Results.Abstract;
using DertOrtagim.Entities.DBModels;
using DertOrtagim.Entities.DTOs;

namespace DertOrtagim.Business.Abstract
{
    public interface IUserRateService
    {
        IResult AddRate(UserRate userRate);
        IResult AddPoint(UserRateForAddDto userRateForAddDto);
        IDataResult<double> GetUserRateByUserId(int userId);
        IDataResult<double> GetUserRateByUserName(string userName);
        IDataResult<int> GetUserRateCountByUserId(int userId);
        IDataResult<int> GetUserRateCountByUserName(string userName);
    }
}

using Core.Utilities.Results.Abstract;
using DertOrtagim.Entities.DBModels;

namespace DertOrtagim.Business.Abstract
{
    public interface IProfileService
    {
        IResult AddProfile(Profile profile);
        IResult RemoveProfile(int profileId);
        IDataResult<Profile> GetProfileByUserName(string userName);
        IDataResult<Profile> GetProfileByUserId(int userId);
    }
}

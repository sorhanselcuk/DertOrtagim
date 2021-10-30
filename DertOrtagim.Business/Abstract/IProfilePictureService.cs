using Core.Utilities.Results.Abstract;
using DertOrtagim.Entities.DBModels;

namespace DertOrtagim.Business.Abstract
{
    public interface IProfilePictureService
    {
        IResult AddProfilePicture(ProfilePicture profilePicture);
        IResult RemoveProfilePicture(int profilePictureId);
        IDataResult<ProfilePicture> GetProfilePictureByUserId(int userId);
        IDataResult<ProfilePicture> GetProfilePictureByUserName(string userName);
    }
}

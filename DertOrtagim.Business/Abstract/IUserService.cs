using Core.Entities.SecurityModels;
using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DertOrtagim.Business.Abstract
{
    public interface IUserService
    { 
        IResult Add(User user);
        User GetByMail(string email);
        User GetUserById(int userId);
        User GetByUserName(string userName);
        IDataResult<int> GetUserIdByUserName(string userName);
    }
}

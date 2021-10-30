using Core.Utilities.Results.Abstract;
using DertOrtagim.Entities.DBModels;
using System.Collections.Generic;

namespace DertOrtagim.Business.Abstract
{
    public interface IMessageService
    {
        IResult SendMessage(Message message);
        IDataResult<List<Message>> GetMessagesByFromUserId(int userId);
    }
}

using Core.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DertOrtagim.Business.Abstract;
using DertOrtagim.DataAccess.Abstract;
using DertOrtagim.Entities.DBModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DertOrtagim.Business.Managers
{
    public class MessageManager : IMessageService
    {
        private IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public IDataResult<List<Message>> GetMessagesByFromUserId(int userId)
        {
            var messages = _messageDal.GetAll(m=>m.FromUserId == userId);
            return new SuccessDataResult<List<Message>>(messages,Messages.Success);
        }

        public IResult SendMessage(Message message)
        {
            _messageDal.Add(message);
            return new SuccessResult(Messages.Success);
        }
    }
}

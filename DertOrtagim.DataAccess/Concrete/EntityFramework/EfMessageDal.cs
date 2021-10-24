using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DertOrtagim.DataAccess.Concrete.EntityFramework.Contexts;
using DertOrtagim.Entities.DBModels;

namespace DertOrtagim.DataAccess.Concrete.EntityFramework
{
    public class EfMessageDal : EfEntityRepositoryBase<Message, DertOrtagimDBContext>, IEntityRepository<Message>
    {
    }
}

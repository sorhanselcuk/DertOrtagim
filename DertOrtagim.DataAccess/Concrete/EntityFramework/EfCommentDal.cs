using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DertOrtagim.DataAccess.Concrete.EntityFramework.Contexts;
using DertOrtagim.Entities.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DertOrtagim.DataAccess.Concrete.EntityFramework
{
    public class EfCommentDal : EfEntityRepositoryBase<Comment,DertOrtagimDBContext>,IEntityRepository<Comment>
    {
    }
}

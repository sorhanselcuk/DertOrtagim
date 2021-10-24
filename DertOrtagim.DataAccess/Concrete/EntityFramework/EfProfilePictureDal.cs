﻿using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DertOrtagim.DataAccess.Concrete.EntityFramework.Contexts;
using DertOrtagim.Entities.DBModels;

namespace DertOrtagim.DataAccess.Concrete.EntityFramework
{
    public class EfProfilePictureDal : EfEntityRepositoryBase<ProfilePicture, DertOrtagimDBContext>, IEntityRepository<ProfilePicture>
    {
    }
}

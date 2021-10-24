using Core.Entities;

namespace DertOrtagim.Entities.DBModels
{
    public class ProfilePicture : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public byte[] Data { get; set; }
    }
   
}

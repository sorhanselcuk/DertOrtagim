using Core.Entities;

namespace DertOrtagim.Entities.DBModels
{
    public class Like : IEntity
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
    }
   
}

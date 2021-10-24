using Core.Entities;

namespace DertOrtagim.Entities.DBModels
{
    public class UserRate : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public double Rate { get; set; }
        public int RateCount { get; set; }
    }
   
}

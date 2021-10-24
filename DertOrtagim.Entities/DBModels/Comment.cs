using Core.Entities;
using System;

namespace DertOrtagim.Entities.DBModels
{
    public class Comment : IEntity
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int Text { get; set; }
        public DateTime Date { get; set; }
    }
   
}

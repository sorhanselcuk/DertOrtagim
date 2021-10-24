using Core.Entities;
using System;

namespace DertOrtagim.Entities.DBModels
{
    public class Post : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
   
}

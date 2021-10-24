using Core.Entities;
using System;

namespace DertOrtagim.Entities.DBModels
{
    public class Message : IEntity
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public int FromUserId { get; set; }
        public int ToUserId { get; set; }
    }
   
}

using Core.Entities;
using System;

namespace DertOrtagim.Entities.DBModels
{
    public class Profile : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Sex { get; set; }
    }
   
}

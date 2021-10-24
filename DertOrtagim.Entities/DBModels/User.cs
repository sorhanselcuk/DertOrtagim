using Core.Entities;
using System.Collections.Generic;
using System.Text;

namespace DertOrtagim.Entities.DBModels
{
    public class User:IEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string EMail { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
   
}

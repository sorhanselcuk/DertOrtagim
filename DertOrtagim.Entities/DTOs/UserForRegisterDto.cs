using System;
using System.Collections.Generic;
using System.Text;

namespace DertOrtagim.Entities.DTOs
{
    public class UserForRegisterDto
    {
        public string EMail { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}

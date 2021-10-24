using System;
using System.Collections.Generic;
using System.Text;

namespace DertOrtagim.Entities.DTOs
{
    public class PostForReturnDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public byte[] ProfilePicture { get; set; }
        public string Text { get; set; }
        public int LikeCount { get; set; }
        public int CommentCount { get; set; }
        public DateTime Date { get; set; }
    }
}

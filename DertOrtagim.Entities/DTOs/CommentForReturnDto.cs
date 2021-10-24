using System;

namespace DertOrtagim.Entities.DTOs
{
    public class CommentForReturnDto
    {
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string CommentText { get; set; }
        public DateTime CommentDate { get; set; }
    }
}

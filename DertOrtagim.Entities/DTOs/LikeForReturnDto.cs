using System;
using System.Collections.Generic;
using System.Text;

namespace DertOrtagim.Entities.DTOs
{
    public class LikeForReturnDto
    {
        public int PostId { get; set; }
        public List<int> UserIds { get; set; }
    }
}
